using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InputProcessor : MonoBehaviour {

	public Text textNick;
	public Text inputfieldNick;

	String[] filter = { "바보", "멍청", "fuck", "젠장", "애미","니미","시발","병신",
						"게임마스터", "GM","겜마", "개발자","운영자","운영","영자",};

	public void OnChangeNick(){
		Debug.Log ("OnChangeNick Clicked");

		int i;
		int Byte=0;

		if (specialChar (inputfieldNick.text)) {
			textNick.text = "특수 문자 포함.";
			return;
		}


		for (i = 0; i < filter.Length; i++) {
			if (inputfieldNick.text.Contains(filter[i])) {
				textNick.text = "사용할 수 없는 닉네임입니다.";
				break;
			}
		}
			
		for (int j = 0; j < inputfieldNick.text.Length; j++) {
			if ((inputfieldNick.text [j] >= 'a' && inputfieldNick.text [j] <= 'z') || (inputfieldNick.text [j] >= 'A' && inputfieldNick.text [j] <= 'Z') || (inputfieldNick.text[j] >= '0' && inputfieldNick.text[j] <='9'))
				Byte++;
			else
				Byte += 2;
		}

		if (Byte > 12) {
			textNick.text = "한글 6자, 영어, 숫자 12자 이내로 입력해 주세요.";
			return;
		}

		if(i == filter.Length)
		textNick.text = "닉네임 : " + inputfieldNick.text;

	}

	void Start(){
		Debug.Log ("start");
	}

	bool specialChar(String n){
		Debug.Log ("sChar launched");
		for (int i = 0; i < n.Length; i++) {
			if (!((n [i] >= 44032 && n [i] <= 55295) ||		//한글
				(n [i] >= '0' && n [i] <= '9') ||			//숫자									//이 for문은 특수문자를 거르기 위함.
				(n [i] >= 'a' && n [i] <= 'z') ||			//소문자
				(n [i] >= 'A' && n [i] <= 'Z')				//대문자
			)) {
				return true;
			}
		}
		return false;		//특수문자 없을 시
	}
}
