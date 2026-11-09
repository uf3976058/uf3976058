using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xf199f188 : MonoBehaviour
{
    public Button Button;
    public int LoadSceneId;
    public bool IsLoadCurrentScene;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xf44d047f.Instance._0xfa79fc65(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xf44d047f.Instance._0xfa79fc65(this.LoadSceneId));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}