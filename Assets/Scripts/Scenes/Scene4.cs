// Scene1Script.cs (attached to a GameObject in Scene 1)
using UnityEngine;

public class Scene4 : MonoBehaviour
{
    public BookLoader bookLoader;

    void Start()
    {
        //load fourth book
        bookLoader.Initialize(3);
    }
}
