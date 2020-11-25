/*************************
 * 
 * PlayerDriverEditor.cs
 * 
 * Author: Dustin Kaban
 * Date: November 25th, 2020
 * 
 * This handles the PlayerDriver customer editor
 * 
 *************************/

using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PlayerDriver))]
public class PlayerDriverEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
    }

    //CURRENTLY A WORK IN PROGRESS
    /*
    public override void OnInspectorGUI()
    {
        PlayerDriver script = (PlayerDriver)target;
        EditorGUILayout.LabelField("Player Values");
        if (script.player != null)
        {
            script.player.SetSpeed(EditorGUILayout.FloatField("Speed", script.player.GetSpeed())); //Need to change this from GetSpeed or else it'll auto reset each time
            script.player.SetExperience(EditorGUILayout.IntField("Experience", script.player.GetExperience()));
            script.player.SetLevel(EditorGUILayout.IntField("Level", script.player.GetLevel()));
        }
    } */
}
