using UnityEngine;

namespace ET
{
    /// <summary>
    /// 物品品质等级
    /// </summary>
    public enum ItemQuality
    {
        General   = 0, //普通
        Good      = 1, //良好
        Excellent = 2, //精良
        Epic      = 3, //史诗
        Legend    = 4, //传奇
    }
    [ChildOf()]
    public class Item: Entity,IAwake<int>,IDestroy
    {
        //物品配置表
        public int ConfigId = 0;
        
        //物品品质
        public int Quality = 0;
        
        //物品配置数据
        public ItemConfig ItemConfig;
    }

    [FriendOf(typeof (Item))]
    public static class ItemViewHelper
    {
        public static Color ItemQualityColor(this Item item)
        {
            ItemQuality quality = (ItemQuality)item.Quality;
            switch (quality)
            {
                case ItemQuality.General:
                    return Color.white;
                case ItemQuality.Good:
                    return Color.green;
                case ItemQuality.Excellent:
                    return Color.blue;
                case ItemQuality.Epic:
                    return Color.magenta;
                case ItemQuality.Legend:
                    return new Color(225.0f / 255, 128.0f / 255, 0.0f);
            }

            return Color.black;
        }
    }
}

