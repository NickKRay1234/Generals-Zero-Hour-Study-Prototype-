using UnityEngine;
using UnityEngine.Events;
using Mirror;

public class Unit : NetworkBehaviour
{
    [SerializeField] private UnityEvent onSelected = null;
    [SerializeField] private UnityEvent onDeselected = null;

    #region Client


    [Client]
    public void Select()
    {
        if(!hasAuthority) {return;}
        onSelected?.Invoke();
    }

    [Client]
    public void Deselect()
    {
        if(!hasAuthority) {return;}
        onDeselected?.Invoke();
    }

   #endregion 




}
