// Scene1Script.cs (attached to a GameObject in Scene 1)
using UnityEngine;

public class Scene1 : MonoBehaviour
{
    public BookLoader bookLoader;

    void Start()
    {
        //load first book 
        bookLoader.Initialize(0);
    }
}
