using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ItemConfigCategory : ConfigSingleton<ItemConfigCategory>, IMerge
    {
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ItemConfig> dict = new Dictionary<int, ItemConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ItemConfig> list = new List<ItemConfig>();
		
        public void Merge(object o)
        {
            ItemConfigCategory s = o as ItemConfigCategory;
            this.list.AddRange(s.list);
        }
		
		[ProtoAfterDeserialization]        
        public void ProtoEndInit()
        {
            foreach (ItemConfig config in list)
            {
                config.AfterEndInit();
                try
                {
                    this.dict.Add(config.Id, config);
                }
                catch (Exception e)
                {
                    Log.Console($"{config.Id} error:{e}");
                    Log.Error($"{config.Id} error:{e}");
                }
                
            }
            
            
            this.list.Clear();
            
            this.AfterEndInit();
        }
		
        public ItemConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ItemConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ItemConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ItemConfig> GetAll()
        {
            return this.dict;
        }

        public ItemConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ItemConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public string Name { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(3)]
		public string Desc { get; set; }
		/// <summary>物品类型</summary>
		[ProtoMember(4)]
		public int Type { get; set; }
		/// <summary>装配位置</summary>
		[ProtoMember(5)]
		public int EquipPosition { get; set; }
		/// <summary>c图标</summary>
		[ProtoMember(6)]
		public string Icon { get; set; }
		/// <summary>最大累加数量</summary>
		[ProtoMember(7)]
		public int MaxSumCount { get; set; }
		/// <summary>s词条随机Id</summary>
		[ProtoMember(8)]
		public int EntryRandomId { get; set; }
		/// <summary>售卖的基础价格</summary>
		[ProtoMember(9)]
		public int SellBasePrice { get; set; }

	}
}
