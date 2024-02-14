using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class StartSceneDOTween : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cMonTxt;
    [SerializeField] private TextMeshProUGUI myGirlsTxt;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        Invoke("StartScene", 1f);
    }

    void StartScene()
    {
        StartCoroutine("StartSceneAnime_Txt");
    }

    IEnumerator StartSceneAnime_Txt()
    {
        cMonTxt.transform.DOLocalMoveY(400, 1f).SetEase(Ease.OutBounce);
        yield return new WaitForSeconds(1f);
        myGirlsTxt.transform.DOLocalMoveY(250, 1f).SetEase(Ease.OutBounce);
        yield return new WaitForSeconds(1f);
        animator.SetBool("isEnded", true);
    }
}
