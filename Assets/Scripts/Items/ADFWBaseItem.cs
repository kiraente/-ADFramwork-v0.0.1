using UnityEngine;
using System.Collections;

namespace ADFramework.ItemCollections
{
    public abstract class ADFWBaseItem:MonoBehaviour
    {
        protected string _Name;
        protected string _Desc;

        public abstract string ADFWName{get;set;}
        public abstract string ADFWDescription{get;set;}

    }

}

