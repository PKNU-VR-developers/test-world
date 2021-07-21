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
            print("������ ��Ʈ�ѷ� A ��ư Get");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� B ��ư Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� ��ƽ ��ư Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� ���� Ʈ���� Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� ���� Ʈ���� Get");
        }
        else if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� A ��ư Get");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� B ��ư Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� ��ƽ ��ư Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� ���� Ʈ���� Get");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� ���� Ʈ���� Get");
        }
    }

    void GetDown()
    {
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� A ��ư GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� B ��ư GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� ��ƽ ��ư GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� ���� Ʈ���� GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� ���� Ʈ���� GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� A ��ư GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� B ��ư GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� ��ƽ ��ư GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� ���� Ʈ���� GetDown");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� ���� Ʈ���� GetDown");
        }
    }

    void GetUp()
    {
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� A ��ư GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� B ��ư GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� ��ƽ ��ư GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� ���� Ʈ���� GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            print("������ ��Ʈ�ѷ� ���� Ʈ���� GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� A ��ư GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� B ��ư GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� ��ƽ ��ư GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� ���� Ʈ���� GetUp");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            print("���� ��Ʈ�ѷ� ���� Ʈ���� GetUp");
        }
    }
}
