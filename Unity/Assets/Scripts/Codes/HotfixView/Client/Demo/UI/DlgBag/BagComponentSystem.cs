using UnityEditor;

namespace ET.Client
{
    [FriendOf(typeof(BagComponent))]
    [FriendOfAttribute(typeof(ET.Item))]
    public static class BagComponentSystem
    {
        [ObjectSystem]
        public class BagComponentDestorySystem : DestroySystem<BagComponent>
        {
            protected override void Destroy(BagComponent self)
            {
                self.Clear();
            }
        }
        /// <summary>
        /// 是否达到最大负载
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static bool IsMaxLoad(this BagComponent self)
        {
            NumericComponent numericComponent = UnitHelper.GetMyUnitNumericComponent(self.ClientScene().CurrentScene());
            return self.ItemDict.Count == numericComponent[NumericType.MaxBagCapacity];
        }

        public static void Clear(this BagComponent self)
        {
            ForeachHelper.Foreach(self.ItemDict, ((id, item) =>
            {
                item?.Dispose();
            }));
            self.ItemDict.Clear();
            self.ItemMap.Clear();
        }

        public static int GetItemCountByItemType(this BagComponent self, ItemType itemType)
        {
            if (!self.ItemMap.ContainsKey((int)itemType))
            {
                return 0;
            }

            return self.ItemMap[(int)itemType].Count;
        }

        public static void AddItem(this BagComponent self, Item item)
        {
            self.AddChild(item);
            self.ItemDict.Add(item.Id, item);
            self.ItemMap.Add(item.ItemConfig.Type, item);
        }

        public static void RemoveItem(this BagComponent self, Item item)
        {
            if (item==null)
            {
                Log.Error("bag item is null");
                return;
            }

            self.ItemDict.Remove(item.Id);
            self.ItemMap.Remove(item.ItemConfig.Type, item);
            item?.Dispose();
        }

        public static Item GetItemById(this BagComponent self, long itemId)
        {
            if (self.ItemDict.TryGetValue(itemId,out Item item))
            {
                return item;
            }

            return null;
        }
    }
}

