using UnityEngine;

namespace GamedevsToolbox.Examples
{
    public class ImGUITest : ImGUI.ImGUI
    {
        protected override void OnImGUI()
        {
            base.OnImGUI();
            GUILayout.Label("Hola! esto es una prueba");
            GUILayout.Button("Esto es un boton");
        }
    }
}