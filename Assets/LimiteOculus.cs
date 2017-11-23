using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using VRStandardAssets.Utils;


public class LimiteOculus : MonoBehaviour {

    //2- Se o usuário sair do limite do alcance do Oculus, ele de ser informado para retornar. 
    //Ou seja a cabeça do usuário deve estar sempre dentro da uma certa área.
    // Use this for initialization

    void Start () {
        InputTracking.GetLocalPosition(VRNode.Head);//Para descobrir a posição da cabeça do usuário

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
