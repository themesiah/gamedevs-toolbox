using UnityEngine;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace GamedevsToolbox.ImGUI {
    public abstract class ImGUI : MonoBehaviour
    {
        [SerializeField]
        private string boxName = "";
        [SerializeField]
        private Vector2 boxSize = Vector2.zero;
        [SerializeField]
        private Vector2 hiddenBoxSize = Vector2.zero;


        private Vector2 currentBoxSize = Vector2.zero;
        private Vector2 currentBoxPosition = Vector2.zero;
        private bool boxVisible = true;

        private bool dragging = false;
        private Vector2 startDragPosition = Vector2.zero;
        private Vector2 startBoxPosition = Vector2.zero;

        protected virtual void Start()
        {
            currentBoxSize = boxSize;
            currentBoxPosition = new Vector2(50f, 50f);
        }

        private void OnGUI()
        {
            GUI.Box(new Rect(currentBoxPosition, currentBoxSize), "");
            GUI.Box(new Rect(currentBoxPosition, hiddenBoxSize), boxName);
            GUILayout.BeginArea(new Rect(currentBoxPosition, currentBoxSize));

            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("-"))
            {
                boxVisible = !boxVisible;
                currentBoxSize = boxVisible ? boxSize : hiddenBoxSize;
            }
            GUILayout.EndHorizontal();

            if (boxVisible)
            {
                OnImGUI();
            }

            GUILayout.EndArea();
        }

        protected virtual void OnImGUI()
        {

        }

#if ENABLE_INPUT_SYSTEM
        public void Drag(InputAction.CallbackContext context)
        {
            var dragPosition = context.ReadValue<Vector2>();
            dragPosition.y = Screen.height - dragPosition.y;

            if (context.started)
            {
                Rect r = new Rect(currentBoxPosition, hiddenBoxSize);
                if (r.Contains(dragPosition))
                {
                    dragging = true;
                    startDragPosition = dragPosition;
                    startBoxPosition = currentBoxPosition;
                }
            }
            else if (context.performed && dragging)
            {
                currentBoxPosition = startBoxPosition + (dragPosition - startDragPosition);
            }
            else if (context.canceled)
            {
                dragging = false;
            }
        }
#endif
    }
}
