using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QnA_M : MonoBehaviour{
    private string[] data = {
        "1.재고자산은 유동자산이다.", 
        "2. 유형자산은 유동자산, 무형자산은 비유동 자산이다.", 
        "3. 비품은 재고자산이다.", 
        "4. 토지는 유형자산이다.",
        "5. 무형자산은 물리적 형태가 없으며 식별이 불가능하다.",
        "6. 개발비는 무형자산이다.",
        "7. 차변에는 자산, 대변에는 자본 부채이다.",
        "8. 제무제표 차변의 합계와 대변의 합계는 항상 일치해야한다.",
        "9. 건물의 화재로 인한 건물 소실은 회계상 거래이나, 일상적인 거래가 아니다.",
        "10. 은행과의 당좌 계약 체결은 일상적인 거래이나, 회계상 거래가 아니다.",
        "11. 판매촉진은 구매 시점 단계에서 자극을 통해 고객의 현장 구매 행동을 유도하는 장기 매출증대 활동을 말한다.",
        "12. 유통점포의 판매촉진 계획수립 단계는 5단계로 나타낼 수 있다.",
        "13. 복리후생비란 노동능률의 유지, 향상을 위해 종업원에게 지급하는 복리후생비적 비용을 의미한다.",
        "14. 인센티브는 일종의 판매 지원금이다.",
        "15. 거래상 쿠폰, 구매공제은 인센티브에 속한다.",
        "16. 술 판매 장소(호프, 고기집 등) 에 주류 포스터 부착시, 소매업자에게 제조품을 일정량 추가 지급은 광고 및 진열공제에 속한다.", 
        "17. 초코파이 등의 과자 판매 율이 일정 기간 동안 가장 높았던 점포에 추가 과자를 지급하는것은 광고 및 진열공제이다." 
        };
    private string[] answer = { "O", "X", "X", "O", "X", "O", "O", "O", "O", "O", "X", "X", "O", "O", "X", "O", "X" };
    public string input;
    public int index = 0;
    public int score = 0;
    public Text q;

    private void Update() {
        if(index < answer.Length)
            q.text = data[index];
        else
            SceneManager.LoadScene(1);
    }

    public bool check(){
        if(index >= answer.Length)
            return false;

        return answer[index] == input;
    }
}
