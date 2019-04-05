using UnityEditor;
using Siren.Utilities.Editor;

namespace Siren.Editor
{
    /// <summary>
    /// Contains menu items to open things from the audio editor
    /// </summary>
    public class AudioMenu
    {
        [MenuItem("Window/Siren/SFX")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow<AudioSystemWindow>();
        }
    }
}