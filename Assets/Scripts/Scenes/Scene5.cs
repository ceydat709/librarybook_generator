// Scene1Script.cs (attached to a GameObject in Scene 1)
using UnityEngine;

public class Scene5 : MonoBehaviour
{
    public BookLoader bookLoader;

    void Start()
    {
        //load fifth book
        bookLoader.Initialize(4);
    }
}
