using UnityEditor;
using Siren.Utilities.Editor;

namespace Siren.Editor
{
    /// <summary>
    /// Contains menu items to open things from the audio editor
    /// </summary>
    public class AudioMenu
    {
        [MenuItem("Assets/Create/Audio/AudioAsset")]
        public static void CreateAudioAsset() => AssetUtil.Create<AudioAsset>();

        [MenuItem("Assets/Create/Audio/AudioAssetLibrary")]
        public static void CreateAudioLibrary() => AssetUtil.Create<AudioAssetLibrary>();

        [MenuItem("Window/AudioSystem")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow<AudioSystemWindow>();
        }

        [MenuItem("Window/AudioAsset")]
        public static void ShowAudioAssetWindow()
        {
            EditorWindow.GetWindow<CreateAssetPopup<AudioAsset>>();
        }
    }
}