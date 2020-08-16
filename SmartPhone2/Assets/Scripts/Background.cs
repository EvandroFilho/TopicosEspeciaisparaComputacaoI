using UnityEngine;

public class Background : MonoBehaviour {
    public float speed = 0.1f;
    private Vector2 savedOffset;
    new private Renderer renderer;

    // Use this for initialization
    void Start(){
        renderer = GetComponent<Renderer>();
        savedOffset = renderer.sharedMaterial.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update(){
        float x = Mathf.Repeat(Time.time * speed, 1);
        Vector2 offset = new Vector2(x, savedOffset.y);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

}
