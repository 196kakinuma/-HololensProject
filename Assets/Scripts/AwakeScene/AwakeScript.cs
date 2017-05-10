using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace AwakeScene
{
    class AwakeScript : MonoBehaviour
    {
        /// <summary>
        /// Hololensアプリケーションは起動時に軽いシーンを挟むと良い
        /// </summary>
        void Awake()
        {
            SceneManager.LoadSceneAsync("TestMainScene");
        }
    }
}