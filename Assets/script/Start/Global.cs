using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour {
    public static long money = 0; // 돈
    public static int pg = 0; // 페이지 초기값
    public static bool pg_use = false; // 페이지 사용 여부 
    public static int exp = 1; // 레벨
    public static long exp_value = 0; // 레벨 수치화
    public static int stage = 1; // 스테이지 잠금
    public static float[] Best = { 5000000 ,500000,500000,500000,500000}; // 스테이지별 최고 기록
}
