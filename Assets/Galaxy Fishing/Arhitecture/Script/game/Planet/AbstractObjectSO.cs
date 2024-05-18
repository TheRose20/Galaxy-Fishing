using UnityEngine;

public abstract class AbstractObjectSO : ScriptableObject
{
    [Header("Main parametrs")]
    [SerializeField] protected int Id;
    [SerializeField] protected string Name;

    public int GetId => Id;
    public string GetName => Name;

    public void SetId(int id)
    {
        if (id == 0) 
        Id = id;
    }

}

