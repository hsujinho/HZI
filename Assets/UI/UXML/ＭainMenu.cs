using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ＭainMenu : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    [MenuItem("Window/UI Toolkit/ＭainMenu")]
    public static void ShowExample()
    {
        ＭainMenu wnd = GetWindow<ＭainMenu>();
        wnd.titleContent = new GUIContent("ＭainMenu");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);

        // Instantiate UXML
        VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(labelFromUXML);
    }
}
