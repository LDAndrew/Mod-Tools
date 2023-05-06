using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ac_ObjectPool : MonoBehaviour
{
    [Header("My Object Pools")]
    public List<ac_LocalPools> Pools;

    private List<string> PoolNames = new List<string>();
    static Transform Parent;

    //_______________________________________________________________________________ START INITIALIZATION ___________________________________________________________//
    //_______________________________________________________________________________ START INITIALIZATION ___________________________________________________________//
    //_______________________________________________________________________________ START INITIALIZATION ___________________________________________________________//

    private void Start()
    {
        Parent = transform;
        SavePoolStrings();
        InitializePools();
    }
    private void SavePoolStrings()
    {
        for (int i = 0; i < Pools.Count; i++)
        {
            PoolNames.Add(Pools[i].PoolName);
        }
    }
    private void InitializePools()
    {
        for (int i = 0; i < Pools.Count; i++)
        {
            Pools[i].InitializeLocalPools();
        }
    }

    //_______________________________________________________________________________ START OBJECTS ___________________________________________________________//
    //_______________________________________________________________________________ START OBJECTS ___________________________________________________________//
    //_______________________________________________________________________________ START OBJECTS ___________________________________________________________//

    public GameObject GetObject(string poolName)
    {
        for (int i = 0; i < PoolNames.Count; i++)
        {
            if (string.Equals(PoolNames[i], poolName))
                return Pools[i].GetObject();
        }
        return null;
    }

    public static void ParentObject(Transform Object, bool ShouldParent, Transform ParentObject)
    {
        if (ShouldParent)
        {
            Object.transform.parent = ParentObject;
            Object.transform.position = ParentObject.position;
            Object.transform.rotation = Parent.rotation;
        }
        else
        {
            Object.transform.parent = Parent;
        }
    }

    //_______________________________________________________________________________ START LOCALPOOL ___________________________________________________________//
    //_______________________________________________________________________________ START LOCALPOOL ___________________________________________________________//
    //_______________________________________________________________________________ START LOCALPOOL ___________________________________________________________//

    [System.Serializable]
    public class ac_LocalPools
    {
        [Header("Pool Information")]
        public string PoolName;
        public GameObject PoolObject;
        public int PoolCount;

        [Header("Parent To Object Below?")]
        public bool ParentMe;

        [Header("Parent Index:")]
        public Transform Category;

        [SerializeField] private List<GameObject> LocalPool;
        private int CurrentObject;
        private bool FirstItem = true;

        public void InitializeLocalPools()
        {
            if (PoolCount > 0)
            {
                for (int i = 0; i < PoolCount; i++)
                {
                    GameObject obj = Instantiate(PoolObject) as GameObject;
                    LocalPool.Add(obj);
                    ParentObject(obj.transform, ParentMe, Category);
                }
            }
        }
        public GameObject GetObject()
        {
            if (FirstItem)
            {
                FirstItem = false;
                return LocalPool[0];
            }
            else
            {
                NextObject();
                return LocalPool[CurrentObject];
            }
        }
        public void NextObject()
        {
            CurrentObject += 1;
            if (CurrentObject == LocalPool.Count)
            {
                CurrentObject = 0;
            }
        }
    }
}