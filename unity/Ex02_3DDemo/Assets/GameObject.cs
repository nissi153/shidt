using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    //Start()�Լ� ������ �ʱ�ȭ �ڵ尡 �ʿ��Ҷ� ���.
    void Awake() {
        Debug.Log("Awake Called.");
    }
    //Update()�Լ��� ȣ��� �Ŀ� ȣ���(��ó��-ī�޶� Fellow)
    void LateUpdate() {
       // Debug.Log("LateUpdate Called.");
    }

    //��ũ��Ʈ ���۽� �ѹ��� ȣ��
    void Start()
    {
        Debug.Log("Hello Unity!");
    }

    int count = 0;

    //�� �����Ӹ��� ȣ�� ex)30fps  1�ʿ� 30�� ȣ���.
    // 1000ms / 30 = 0.033�ʸ��� �ѹ� ȣ��
    //����! �ð��� �����ɸ��� �ڵ带 ������ �ӵ��� ������!
    void Update()
    {
        //Debug.Log("Update Count:" + this.count++);
    }
}
