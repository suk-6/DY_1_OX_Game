using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_M : MonoBehaviour
{
    private string[] data = {
        "1. 기후요소 중 인간의 체온 조절에 중요한 영향을 미치는 것을 온열요소라 한다. 4대 온열요소 중 3글자로 된 요소를 쓰시오.",
        "2. 이타이이타이병은 어떤 물질에 대한 중독 현상인가? (띄어쓰기 없이 작성하세요.)",
        "3. 피부결핵 환자의 이불을 태양광선 3가지 중 하나의 방법으로 살균해야 한다. 3가지 중 옳은 것은?",
        "4. 욕창 1~4단계 중 피하 조직이 관찰되나 근육, 건, 뼈는 노출되지 않은 단계는? (n단계라고 작성하세요)",
        "5. 기후변화와 국제협약 - 교통의정서 다음 국제 협약은 무엇인가 (띄어쓰기 없이 작성하세요.)",
        "6. 뇌전증은 뇌의 비장상적인 전기 활동의 결과로 반복적으로 ㅁㅁ을 일으킨다. ㅁㅁ는 무엇인가?",
        "7. 응급처치 구명 4단계는? (띄어쓰기 없이 작성하시고, 단계 사이에는 하이픈(-)을 넣어주세요.)",
        "8. 심장 마비시 4분 이내로 심폐소생술을 실시해야 하는 것은 어느 곳이 제일 위험하기 때문일까요?",
        "9. 적혈구 응집원이 없어 어느 혈액형이 환자에게나 공급할 수 있는 혈액형은? (ex, A형)",
        "10. 알츠하이머는 치매를 말한다. 치매 증상 중 시간, 장소, 시간에 대한 지각 능력이 저하하는데 위 증상의 이름은?"
    };
    private string[] answer = { "복사열", "카드뮴중독", "자외선", "3단계", "파리기후협정", "발작", "기도유지-지혈-쇼크예방-상처보호", "뇌", "O형", "지남력" };
    public InputField input;
    private string input_data;
    private int index = 0;
    private int score;
    public Text q;
    private void Start() {
        q.text = data[index];
    }
    public void push()
    {
        if (input.text == "") return;

        input_data = input.text;
        if (input_data == answer[index++])
            score++;
            q.text = data[index];
        input.text = "";
        Debug.Log(score);
    }
}