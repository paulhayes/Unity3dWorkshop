using UnityEngine;
using System.Collections;
using System.Linq;

public class CreateTexture : MonoBehaviour 
{
	public int width;
	public int height;
	public TextureFormat format;
	public Color color;
	
	void Awake () 
	{
		Texture2D texture = new Texture2D(width, height, format, false);
		texture.SetPixels( texture.GetPixels().Select( c=>color ).ToArray() );
		texture.Apply();
		renderer.material.mainTexture = texture;
		
	}
	
	void Update ()
	{
	
	}
}
