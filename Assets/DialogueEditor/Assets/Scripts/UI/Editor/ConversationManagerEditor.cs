using UnityEngine;
using UnityEditor;

namespace DialogueEditor
{
    [CustomEditor(typeof(ConversationManager))]
    public class ConversationManagerEditor : Editor
    {
        private const string PREVIEW_TEXT = "Placeholder text. This image acts as a preview of the in-game GUI.";
        private const float BOX_HEIGHT = 75;
        private const float BUFFER = 15;

        private const float BUFFER02 = 250;
        private const float BUFFER03 = 250;
        private const float BUFFER04 = 250;
        private const float BUFFER05 = 250;


        private const float ICON_SIZE = 50;
        private const float OPTION_HEIGHT = 35;
        private const float OPTION_BUFFER = 5;
        private const float OPTION_TEXT_BUF_Y = 10;


        SerializedProperty BackgroundImageProperty;
        SerializedProperty BackgroundImageSlicedProperty;
        SerializedProperty OptionImageProperty;
        SerializedProperty OptionImageSlicedProperty;
        SerializedProperty ScrollTextProperty;
        SerializedProperty ScrollTextSpeedProperty;
        SerializedProperty AllowMouseInteractionProperty;

        SerializedProperty BlankSprite02;
        SerializedProperty BlankSprite03;
        SerializedProperty BlankSprite04;
        SerializedProperty BlankSprite05;
        SerializedProperty BlankSprite;
        SerializedProperty NpcIcon02;
        //SerializedProperty NpcIcon03;
        SerializedProperty NpcIcon04;
        SerializedProperty NpcIcon05;
        SerializedProperty PanelAvance;
        //SerializedProperty canvasAparece;

        private void OnEnable()
        {
            BackgroundImageProperty = serializedObject.FindProperty("BackgroundImage");
            BackgroundImageSlicedProperty = serializedObject.FindProperty("BackgroundImageSliced");
            OptionImageProperty = serializedObject.FindProperty("OptionImage");
            OptionImageSlicedProperty = serializedObject.FindProperty("OptionImageSliced");
            ScrollTextProperty = serializedObject.FindProperty("ScrollText");
            ScrollTextSpeedProperty = serializedObject.FindProperty("ScrollSpeed");
            AllowMouseInteractionProperty = serializedObject.FindProperty("AllowMouseInteraction");
            BlankSprite = serializedObject.FindProperty("BlankSprite");
            BlankSprite02 = serializedObject.FindProperty("BlankSprite02");
            BlankSprite03 = serializedObject.FindProperty("BlankSprite03");
            BlankSprite04 = serializedObject.FindProperty("BlankSprite04");
            BlankSprite05 = serializedObject.FindProperty("BlankSprite05");
            NpcIcon02 = serializedObject.FindProperty("NpcIcon02");
            //NpcIcon03 = serializedObject.FindProperty("NpcIcon03");
            NpcIcon04 = serializedObject.FindProperty("NpcIcon04");
            NpcIcon05 = serializedObject.FindProperty("NpcIcon05");
            PanelAvance = serializedObject.FindProperty("AvanzarPanel");
            //canvasAparece = serializedObject.FindProperty("CanvasApa");
        }

        public override void OnInspectorGUI()
        {
            // Update the serializedProperty - always do this in the beginning of OnInspectorGUI.
            serializedObject.Update();
            ConversationManager t = (ConversationManager)target;

            RenderPreviewImage(t);

            // Create a gap in EditorGuiLayout for the preview image to be rendered
            EditorGUILayout.BeginVertical();
            GUILayout.Space(BOX_HEIGHT + OPTION_BUFFER + OPTION_HEIGHT);
            EditorGUILayout.EndVertical();

            // Background image
            GUILayout.Label("Dialogue Image Background Options", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(BackgroundImageProperty);
            EditorGUILayout.PropertyField(BackgroundImageSlicedProperty); 
            EditorGUILayout.Space();

            // Option image
            GUILayout.Label("Dialogue Image Options", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(OptionImageProperty);
            EditorGUILayout.PropertyField(OptionImageSlicedProperty);
            EditorGUILayout.Space();

            // Text
            GUILayout.Label("Text options", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(ScrollTextProperty);
            if (t.ScrollText)
                EditorGUILayout.PropertyField(ScrollTextSpeedProperty);
            EditorGUILayout.Space();

            // Interaction options
            GUILayout.Label("Interaction options", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(AllowMouseInteractionProperty);

            EditorGUILayout.PropertyField(BlankSprite);
            EditorGUILayout.PropertyField(BlankSprite02);
            EditorGUILayout.PropertyField(BlankSprite03);
            EditorGUILayout.PropertyField(BlankSprite04);
            EditorGUILayout.PropertyField(BlankSprite05);
            

            EditorGUILayout.PropertyField(NpcIcon02);
            //EditorGUILayout.PropertyField(NpcIcon03);
            EditorGUILayout.PropertyField(NpcIcon04);
            EditorGUILayout.PropertyField(NpcIcon05);

            EditorGUILayout.PropertyField(PanelAvance);

            //EditorGUILayout.PropertyField(canvasAparece);




            // Apply changes to the serializedProperty - always do this in the end of OnInspectorGUI.
            serializedObject.ApplyModifiedProperties();
        }

        private void RenderPreviewImage(ConversationManager t)
        {
            Rect contextRect = EditorGUILayout.GetControlRect();

            // Draw a background box
            Rect boxRect;
            float width, height;
            width = contextRect.width * 0.75f;
            height = BOX_HEIGHT;
            if (t.BackgroundImage == null)
            {
                boxRect = new Rect(contextRect.x + contextRect.width * 0.125f, contextRect.y + 10, width, height);
                EditorGUI.DrawRect(boxRect, Color.black);
            }
            else
            {
                boxRect = new Rect(contextRect.x + contextRect.width * 0.125f, contextRect.y + 10, width, height);

                if (t.BackgroundImageSliced)
                {
                    GUIStyle style = new GUIStyle();
                    RectOffset ro = new RectOffset();
                    ro.left = (int)t.BackgroundImage.border.w;
                    ro.top = (int)t.BackgroundImage.border.x;
                    ro.right = (int)t.BackgroundImage.border.y;
                    ro.bottom = (int)t.BackgroundImage.border.z;
                    style.border = ro;
                    style.normal.background = t.BackgroundImage.texture;
                    EditorGUI.LabelField(boxRect, "", style);
                }
                else
                {
                    GUI.DrawTexture(boxRect, t.BackgroundImage.texture);
                }
            }


            // Draw icon
            float difference = BOX_HEIGHT - ICON_SIZE;
            Rect iconRect = new Rect(boxRect.x + BUFFER, boxRect.y + difference * 0.5f, ICON_SIZE, ICON_SIZE);
            EditorGUI.DrawRect(iconRect, Color.white);
            Rect tmpt = new Rect(iconRect);
            tmpt.x += 2f;
            tmpt.y += ICON_SIZE * 0.1f;
            EditorGUI.LabelField(tmpt, "<Icon>");


            Rect iconRect02 = new Rect(boxRect.x + BUFFER02, boxRect.y + difference * 0.5f, ICON_SIZE, ICON_SIZE);
            EditorGUI.DrawRect(iconRect02, Color.red);
            Rect tmpt02 = new Rect(iconRect02);
            tmpt02.x += 1f;
            tmpt02.y += ICON_SIZE * 0.1f;
            EditorGUI.LabelField(tmpt02, "<Icon02>");

            Rect iconRect03 = new Rect(boxRect.x + BUFFER03, boxRect.y + difference * 0.5f, ICON_SIZE, ICON_SIZE);
            EditorGUI.DrawRect(iconRect03, Color.red);
            Rect tmpt03 = new Rect(iconRect03);
            tmpt03.x += 1f;
            tmpt03.y += ICON_SIZE * 0.1f;
            EditorGUI.LabelField(tmpt03, "<Icon03>");

            Rect iconRect04 = new Rect(boxRect.x + BUFFER04, boxRect.y + difference * 0.5f, ICON_SIZE, ICON_SIZE);
            EditorGUI.DrawRect(iconRect04, Color.red);
            Rect tmpt04 = new Rect(iconRect04);
            tmpt04.x += 1f;
            tmpt04.y += ICON_SIZE * 0.1f;
            EditorGUI.LabelField(tmpt04, "<Icon04>");

            Rect iconRect05 = new Rect(boxRect.x + BUFFER05, boxRect.y + difference * 0.5f, ICON_SIZE, ICON_SIZE);
            EditorGUI.DrawRect(iconRect05, Color.red);
            Rect tmpt05 = new Rect(iconRect05);
            tmpt05.x += 1f;
            tmpt05.y += ICON_SIZE * 0.1f;
            EditorGUI.LabelField(tmpt05, "<Icon05>");




            // Draw text
            float text_x, text_wid;
            text_x = iconRect.x + iconRect.width + difference * 0.5f;
            text_wid = ((boxRect.x + boxRect.width) - difference * 0.5f) - text_x*1.4f;
            Rect textRect = new Rect(text_x, iconRect.y, text_wid, ICON_SIZE);
            GUIStyle textStyle = new GUIStyle();
            textStyle.normal.textColor = Color.white;
            textStyle.wordWrap = true;
            textStyle.clipping = TextClipping.Clip;
            EditorGUI.LabelField(textRect, PREVIEW_TEXT, textStyle);



            text_x = iconRect02.x + iconRect02.width + difference * 0.2f;
            text_wid = ((boxRect.x + boxRect.width) - difference * 0.5f) - text_x;
            Rect textRect02 = new Rect(text_x, iconRect02.y, text_wid, ICON_SIZE);
            GUIStyle textStyle02 = new GUIStyle();
            textStyle02.normal.textColor = Color.blue;
            textStyle02.wordWrap = true;
            textStyle02.clipping = TextClipping.Clip;
            EditorGUI.LabelField(textRect02, PREVIEW_TEXT, textStyle02);

            text_x = iconRect03.x + iconRect03.width + difference * 0.2f;
            text_wid = ((boxRect.x + boxRect.width) - difference * 0.5f) - text_x;
            Rect textRect03 = new Rect(text_x, iconRect03.y, text_wid, ICON_SIZE);
            GUIStyle textStyle03 = new GUIStyle();
            textStyle03.normal.textColor = Color.blue;
            textStyle03.wordWrap = true;
            textStyle03.clipping = TextClipping.Clip;
            EditorGUI.LabelField(textRect03, PREVIEW_TEXT, textStyle03);

            text_x = iconRect04.x + iconRect04.width + difference * 0.2f;
            text_wid = ((boxRect.x + boxRect.width) - difference * 0.5f) - text_x;
            Rect textRect04 = new Rect(text_x, iconRect04.y, text_wid, ICON_SIZE);
            GUIStyle textStyle04 = new GUIStyle();
            textStyle04.normal.textColor = Color.blue;
            textStyle04.wordWrap = true;
            textStyle04.clipping = TextClipping.Clip;
            EditorGUI.LabelField(textRect04, PREVIEW_TEXT, textStyle04);
            
            text_x = iconRect05.x + iconRect05.width + difference * 0.2f;
            text_wid = ((boxRect.x + boxRect.width) - difference * 0.5f) - text_x;
            Rect textRect05 = new Rect(text_x, iconRect05.y, text_wid, ICON_SIZE);
            GUIStyle textStyle05 = new GUIStyle();
            textStyle05.normal.textColor = Color.blue;
            textStyle05.wordWrap = true;
            textStyle05.clipping = TextClipping.Clip;
            EditorGUI.LabelField(textRect05, PREVIEW_TEXT, textStyle05);


            // Option (left)
            float option_x, option_wid;
            option_wid = boxRect.width * 0.8f;
            option_x = boxRect.x + boxRect.width * 0.1f;
            Rect optionRect = new Rect(option_x, boxRect.y + boxRect.height + OPTION_BUFFER, option_wid, OPTION_HEIGHT);
            Rect optionTextRect = new Rect(optionRect);
            optionTextRect.x += optionRect.width * 0.4f;
            optionTextRect.y += OPTION_TEXT_BUF_Y;
            if (t.OptionImage == null)
            {
                EditorGUI.DrawRect(optionRect, Color.black);
            }
            else
            {
                if (t.OptionImageSliced)
                {
                    GUIStyle style = new GUIStyle();
                    RectOffset ro = new RectOffset();
                    ro.left = (int)t.OptionImage.border.w;
                    ro.top = (int)t.OptionImage.border.x;
                    ro.right = (int)t.OptionImage.border.y;
                    ro.bottom = (int)t.OptionImage.border.z;
                    style.border = ro;
                    style.normal.background = t.OptionImage.texture;
                    EditorGUI.LabelField(optionRect, "", style);
                }
                else
                {
                    GUI.DrawTexture(optionRect, t.OptionImage.texture, ScaleMode.StretchToFill);
                }
            }
            EditorGUI.LabelField(optionTextRect, "Opcion.", textStyle);
        }
    }
}