using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestSceneManager : MonoBehaviour
{
    [SerializeField]
    private Image picture;

    private int _pictureIndex = 1;

    private List<Sprite> _sprites = new List<Sprite>(3);

    public void OnEnable()
    {
        if (_sprites.Count == 0)
        {
            for (int i = 0; i < 3; i++)
            {
                var sprite = Resources.Load<Sprite>($"Textures/{i + 1}");
                _sprites.Add(sprite);
            }
        }
    }

    public void ClickNext()
    {
        ++_pictureIndex;
        if (_pictureIndex == 4)
        {
            _pictureIndex = 1;
        }
        SetImage();
    }

    public void ClickPrevious()
    {
        --_pictureIndex;
        if (_pictureIndex == 0)
        {
            _pictureIndex = 3;
        }
        SetImage();
    }

    private void SetImage()
    {
        var sprite = _sprites[_pictureIndex - 1];
        picture.sprite = sprite;
    }
    
    public void LoadEmptyScene()
    {
        var request = SceneManager.LoadSceneAsync("EmptyScene");
        request.completed += RequestOncompleted;
    }

    private void RequestOncompleted(AsyncOperation obj)
    {
        //Debug.Log("Load Empty Scene Twice");
        //SceneManager.LoadSceneAsync("EmptyScene");
    }
}
