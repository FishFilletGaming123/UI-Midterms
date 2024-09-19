using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public GameObject chrcImage;
    public float duration;
    public Ease easing;


    public void ResetPos()
    
    {
        Image colorImage = chrcImage.GetComponent<Image>();        
        chrcImage.transform.DOLocalMove(new Vector3(0,0,0),0.2f)
        .OnComplete(() => chrcImage.transform.DOScale(new Vector3(4.2642808f,4.2642808f,4.2642808f),0.2f)).SetEase(easing).OnComplete(() => colorImage.DOFade(1f, 0.5f));
    }   

    public void FlyRight()
    {
        chrcImage.transform.DOLocalMove(new Vector3(720,0,0),0.5f).SetEase(Ease.InOutBack);
    }

    public void JiggleIn()
    {
        chrcImage.transform.DOScale(new Vector3(5.33867025f,2.82977653f,4.2642808f),0.3f).SetEase(Ease.InBack)
        .OnComplete(() => JiggleOut());
    }

    private void JiggleOut()
    {
        chrcImage.transform.DOScale(new Vector3(3.624724f,4.946566f,4.2642808f),0.2f).SetEase(Ease.InOutBack)
        .OnComplete(() => chrcImage.transform.DOScale(new Vector3(4.2642808f,4.2642808f,4.2642808f),0.2f).SetEase(easing));
    }    

    public void Shake()
    {
        chrcImage.transform.DOShakePosition(1f, new Vector3(30f, 0, 0), 17, 90, false, true);
    }

    public void Pulse()
    {
    Image colorImage = chrcImage.GetComponent<Image>();

    chrcImage.transform.DOScale(new Vector3(3.5105691f,3.5105691f,3.5105691f),0.2f).SetEase(Ease.InOutBack).OnComplete(()=>{chrcImage.transform.DOScale(new Vector3(4.2642808f,4.2642808f,4.2642808f),0.2f).SetEase(Ease.InOutBack);colorImage.DOFade(1f,1f);});colorImage.DOFade(0.4f,0.1f);
    }

    public void FlipHorizontally()
    {
        chrcImage.transform.DOScaleX(-chrcImage.transform.localScale.x, 0.2f).SetEase(Ease.InOutBack);
    }    

    public void FadeLeft()
    {
    Image colorImage = chrcImage.GetComponent<Image>();
    chrcImage.transform.DOLocalMove(new Vector3(-645, 0, 0), 0.5f).SetEase(Ease.InOutSine);
    colorImage.DOFade(0f, 0.5f);
    }
}
