using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameObjectInformation))]
[CanEditMultipleObjects]
public class GameObjectInformationEditor : Editor
{
    SerializedProperty information;
    private bool editing = false;

    void OnEnable()
    {
        information = serializedObject.FindProperty("information");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.HelpBox(information.stringValue.ToString(), MessageType.Info, true);
        if (editing)
        {
            EnableTextArea();
            if (GUILayout.Button("Save"))
            {
                editing = false;
            }
        } else
        {
            if (GUILayout.Button("Edit"))
            {
                EnableTextArea();
                editing = true;
            }
        }
    }
    private void EnableTextArea()
    {
        EditorGUILayout.PropertyField(information, GUIContent.none);
        serializedObject.ApplyModifiedProperties();
    }
}