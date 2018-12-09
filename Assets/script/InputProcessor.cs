using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class InputProcessor : MonoBehaviour {
    public static String UserNick;


	bool nickNameOk;

	public Text inputfieldNick;
    public InputField inputfield;

	public Image smile;
	public Image frown;
    public Image impos;

    public Image reinfo;
    public Text nick;
    public Button check;
    public Button no;

	String[] filter = { "바보", "멍청", "fuck", "젠장", "애미","애미","느금","느개비","니미","시발","새끼","개새","씨발","씨빨","쉬발","새기",
                        "게임마스터", "GM","겜마", "개발자","운영자","운영","영자",};
    
	public void DeleteInput(){
		//Debug.Log ("asdf DELDELTLELE");
        inputfield.Select();
        inputfield.text = "";
	}

	public void OnChangeNick(){
		Debug.Log ("OnChangeNick Clicked");

        bool temp = nickNameOk;
        impos.gameObject.SetActive(!nickNameOk);

        nick.text = inputfieldNick.text;

        reinfo.gameObject.SetActive(nickNameOk);
        nick.gameObject.SetActive(nickNameOk);
        check.gameObject.SetActive(nickNameOk);
        no.gameObject.SetActive(nickNameOk);

    }

    public void clickNo() {
        reinfo.gameObject.SetActive(false);
        nick.gameObject.SetActive(false);
        check.gameObject.SetActive(false);
        no.gameObject.SetActive(false);

        DeleteInput();
    }

    public void clickCheck() {
        reinfo.gameObject.SetActive(false);
        nick.gameObject.SetActive(false);
        check.gameObject.SetActive(false);
        no.gameObject.SetActive(false);

        UserNick = inputfieldNick.text;

        Debug.Log(UserNick);
    }

	bool SpecialChar(){
		//Debug.Log ("sChar launched");
		for (int i = 0; i < inputfieldNick.text.Length; i++) {
			if (!((inputfieldNick.text [i] >= 44032 && inputfieldNick.text [i] <= 55295) ||		//한글
				(inputfieldNick.text [i] >= '0' && inputfieldNick.text [i] <= '9') ||			//숫자									//이 for문은 특수문자를 거르기 위함.
				(inputfieldNick.text [i] >= 'a' && inputfieldNick.text [i] <= 'z') ||			//소문자
				(inputfieldNick.text [i] >= 'A' && inputfieldNick.text [i] <= 'Z')				//대문자
			)) {
				return true;
			}
		}
		return false;		//특수문자 없을 시
	}

	bool HaveYok(){
		//Debug.Log ("haveYok launched");
		for (int i = 0; i < filter.Length; i++) {
			if (inputfieldNick.text.Contains(filter[i])) {
				return true;
			}
		}
		return false;
	}

	bool WhatByte(){
		//Debug.Log ("whatByte launched");
		int Byte = 0;
		for (int j = 0; j < inputfieldNick.text.Length; j++) {
			if ((inputfieldNick.text [j] >= 'a' && inputfieldNick.text [j] <= 'z') || 
				(inputfieldNick.text [j] >= 'A' && inputfieldNick.text [j] <= 'Z') || 
				(inputfieldNick.text[j] >= '0' && inputfieldNick.text[j] <='9'))

				Byte++;
			else
				Byte += 2;
		}

		if (Byte > 12 || Byte <=0)
			return true;
		else
			return false;
	}

	void Update(){
		nickNameOk = ! HaveYok() && ! SpecialChar() && ! WhatByte();				//셋다 false 여야 정상이기때문에 NAND사용.
		Debug.Log(nickNameOk);
		smile.gameObject.SetActive (nickNameOk);
		frown.gameObject.SetActive (!nickNameOk);
	}
}
