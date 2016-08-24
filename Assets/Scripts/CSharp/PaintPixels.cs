using UnityEngine;
using System.Collections;

public class PaintPixels : MonoBehaviour 
{

	public Color color;
	public float brushSize;
	
	protected Texture2D texture;
	
	void Start () 
	{
		texture = GetComponent<Renderer>().sharedMaterial.mainTexture as Texture2D;
	}
	
	void Update ()
	{
		RaycastHit hitInfo;
		bool hit = GetComponent<Collider>().Raycast( Camera.main.ScreenPointToRay( Input.mousePosition ), out hitInfo, float.MaxValue );
		bool mouseDown = Input.GetMouseButton(0);
		if( hit && mouseDown ){
			Vector2 dim = hitInfo.textureCoord;
			dim.x *= texture.width;
			dim.y *= texture.height;
			for( int x=0; x<texture.width; x++ ){
				for( int y=0; y<texture.height; y++){
					Vector2 pos = new Vector2( x, y );
					float distance = brushSize - Vector2.Distance( dim,pos );
					Color current = texture.GetPixel(x,y);
					Color c = Color.Lerp( current, color, distance );
					texture.SetPixel( x, y, c );
				}
			}
			texture.Apply();
		}
	}
	
	
}
