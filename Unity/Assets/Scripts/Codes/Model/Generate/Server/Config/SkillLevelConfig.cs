using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class SkillLevelConfigCategory : ConfigSingleton<SkillLevelConfigCategory>, IMerge
    {
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, SkillLevelConfig> dict = new Dictionary<int, SkillLevelConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<SkillLevelConfig> list = new List<SkillLevelConfig>();
		
        public void Merge(object o)
        {
            SkillLevelConfigCategory s = o as SkillLevelConfigCategory;
            this.list.AddRange(s.list);
        }
		
		[ProtoAfterDeserialization]        
        public void ProtoEndInit()
        {
            foreach (SkillLevelConfig config in list)
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
		
        public SkillLevelConfig Get(int id)
        {
            this.dict.TryGetValue(id, out SkillLevelConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (SkillLevelConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, SkillLevelConfig> GetAll()
        {
            return this.dict;
        }

        public SkillLevelConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class SkillLevelConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>Type</summary>
		[ProtoMember(2)]
		public int Level { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(3)]
		public string Name { get; set; }

	}
}
