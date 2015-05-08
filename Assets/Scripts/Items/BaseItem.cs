using UnityEngine;
using System.Collections;

namespace ADFramework.ItemCollections
{
    public abstract class BaseItem : MonoBehaviour
    {

        protected string _Name;
        protected string _Desc;

        public abstract string Name{get;set;}
        public abstract string Description{get;set;}
        
    }
}

