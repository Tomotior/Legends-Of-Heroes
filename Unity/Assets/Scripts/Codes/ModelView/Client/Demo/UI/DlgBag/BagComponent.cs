using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace ET.Client
{
    [ComponentOf()]
    public  class BagComponent : Entity,IAwake,IDestroy
    {
        [BsonIgnore]
        public Dictionary<long, Item> ItemDict = new Dictionary<long, Item>();
        [BsonIgnore]
        public MultiMap<int, Item> ItemMap = new MultiMap<int, Item>();
      //  [BsonIgnore]
      //  public M2C_ItemUpdateOpInfo message = new M2C_ItemUpdateOpInfo() {ContainerType = (int)ItemContainerType.Bag};
    }
}

