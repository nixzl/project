using UnityEngine;

public class AudioManager : MonoBehaviour
{
  [SerializeField] AudioSource musicSource;
  [SerializeField] AudioSource SFXSource;

  public AudioClip BGM;
  public AudioClip Jump;

  private void Start()
    {
        musicSource.clip = BGM;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(Jump);
    }
}
