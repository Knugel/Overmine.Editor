using System.Collections.Generic;
using System.IO;
using Editor.Util;
using Overmine.API.Assets;
using Thor;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public static class TemplateCreator
    {
        [MenuItem("Assets/Create/Templates/Relic", false, 0)]
        public static void CreateRelicTemplate()
        {
            CopyItem("Relic");
        }
        
        [MenuItem("Assets/Create/Templates/Blessing", false, 0)]
        public static void CreateBlessingTemplate()
        {
            CopyItem("Blessing");
        }
        
        [MenuItem("Assets/Create/Templates/Hex", false, 0)]
        public static void CreateHexTemplate()
        {
            CopyItem("Hex");
        }

        [MenuItem("Assets/Create/Templates/Minor Curse", false, 0)]
        public static void CreateMinorCurseTemplate()
        {
            CopyItem("Minor Curse");
        }
        
        [MenuItem("Assets/Create/Templates/Major Curse", false, 0)]
        public static void CreateMajorCurseTemplate()
        {
            CopyItem("Major Curse");
        }
        
        [MenuItem("Assets/Create/Templates/Entity", false, 0)]
        public static void CreateEntityTemplate()
        {
            Copy<GameObject>("Resources/Templates/Entity.prefab", "Entity.prefab");
        }
        
        [MenuItem("Assets/Create/Templates/Status Effect", false, 0)]
        public static void CreateStatusEffectTemplate()
        {
            var status = Copy<GameObject>("Resources/Templates/Status Effect.prefab", "Status Effect.prefab");
            var statusExt = status.GetComponent<StatusEffectExt>();
            statusExt.Behaviors.Clear();
        }
        
        [MenuItem("Assets/Create/Templates/Potion", false, 0)]
        public static void CreatePotionTemplate()
        {
            var root = "Resources/Templates/Potion";
            
            var item = Copy<ItemData>(Path.Combine(root, "Potion Item.asset"), "Potion Item.asset");
            var pickup = Copy<BehaviourGraph>(Path.Combine(root, "Potion Pickup.asset"), "Potion Pickup.asset");
            item.SetSerializedField("m_pickedUpBehavior", pickup);

            var equipment = Copy<GameObject>(Path.Combine(root, "Potion Equipment.prefab"), "Potion Equipment.prefab");
            var entity = equipment.GetComponent<Entity>();
            var equipmentExt = equipment.GetComponent<EquipmentExt>();
            var casterExt = equipment.GetComponent<CasterExt>();
            entity.SetData(item);
            pickup.BehaviorSource.TaskData.fieldSerializationData.unityObjects[0] = equipmentExt;

            var ability = Copy<GameObject>(Path.Combine(root, "Potion Drink.prefab"), "Potion Drink.prefab");
            var abilityExt = ability.GetComponent<AbilityExt>();
            var abilities = casterExt.GetSerializedField<List<CasterExt.AbilitySlot>>("m_initialAbilitySlots");
            abilities[0].ability = abilityExt;

            var effect = Copy<BehaviourGraph>(Path.Combine(root, "Potion Effect.asset"), "Potion Effect.asset");
            abilityExt.Behaviors[2] = effect;
        }

        private static void CopyItem(string name)
        {
            var root = "Resources/Templates/Item";
            
            var item = Copy<ItemData>(Path.Combine(root, $"{name}.asset"), $"{name} Item.asset");
            var pickup = Copy<BehaviourGraph>(Path.Combine(root, "Picked Up.asset"), $"{name} Picked Up.asset");
            item.SetSerializedField("m_pickedUpBehavior", pickup);

            var status = Copy<GameObject>("Resources/Templates/Status Effect.prefab", "Status Effect.prefab");
            var statusEntity = status.GetComponent<Entity>();
            var statusExt = status.GetComponent<StatusEffectExt>();
            pickup.BehaviorSource.TaskData.fieldSerializationData.unityObjects[0] = statusEntity;

            var effect = Copy<BehaviourGraph>(Path.Combine(root, "Effect.asset"), $"{name} Effect.asset");
            statusExt.Behaviors[0] = effect;
        }

        private static T Copy<T>(string source, string target) where T : Object
        {
            source = Path.Combine(AssetCreator.GetEditorFolder(), source);
            target = GetUniquePath(target);

            AssetDatabase.CopyAsset(source, target);
            var asset = AssetDatabase.LoadAssetAtPath<T>(target);

            switch (asset)
            {
                case ItemData item:
                    AssetCreator.GenerateGuid(item);
                    break;
                case GameObject obj:
                    AssetCreator.GenerateGuid(obj);
                    break;
            }
            
            AssetDatabase.SaveAssets();
            
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
            
            return asset;
        }

        private static string GetUniquePath(string file)
        {
            var obj = Selection.activeObject;
            var path = obj == null ? "Assets" : AssetDatabase.GetAssetPath(obj.GetInstanceID());
            
            if (Path.HasExtension(path))
                path = Path.GetDirectoryName(path);
            
            path = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, file));
            return path;
        }
    }
}