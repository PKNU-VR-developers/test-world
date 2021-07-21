using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetDown();
        Get();
        GetUp();
    }

    void Get()
    {
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 A 버튼 Get");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 B 버튼 Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 스틱 버튼 Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 검지 트리거 Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 중지 트리거 Get");
        }
        else if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 A 버튼 Get");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 B 버튼 Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 스틱 버튼 Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 검지 트리거 Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 중지 트리거 Get");
        }
    }

    void GetDown()
    {
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 A 버튼 GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 B 버튼 GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 스틱 버튼 GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 검지 트리거 GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 중지 트리거 GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 A 버튼 GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 B 버튼 GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 스틱 버튼 GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 검지 트리거 GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 중지 트리거 GetDown");
        }
    }

    void GetUp()
    {
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 A 버튼 GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 B 버튼 GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 스틱 버튼 GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 검지 트리거 GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            print("오른쪽 컨트롤러 중지 트리거 GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 A 버튼 GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 B 버튼 GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 스틱 버튼 GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 검지 트리거 GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            print("왼쪽 컨트롤러 중지 트리거 GetUp");
        }
    }
}
