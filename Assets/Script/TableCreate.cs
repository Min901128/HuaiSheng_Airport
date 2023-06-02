using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TableCreate : MonoBehaviour
{
	public GameObject Row_Prefab;//表头预设
	public GameObject table;
	public int row_count=10;

	void Start()
	{
		for (int i = 0; i < row_count; i++)//添加并修改预设的过程，将创建10行        
		{
			//在Table下创建新的预设实例            
			GameObject row = GameObject.Instantiate
			(
				Row_Prefab,
				table.transform.position,
				table.transform.rotation
			) as GameObject;
			
			row.name = "row" + (i + 1);
			row.transform.SetParent(table.transform);
			row.transform.localScale = Vector3.one;
			//设置缩放比例1,1,1，不然默认的比例非常大
			//设置预设实例中的各个子物体的文本内容
			// row.transform.Find("Cell0").GetComponent<Text>().text = (i + 1) + "";
			// row.transform.Find("Cell1").GetComponent<Text>().text = "name" + (i + 1);
			// row.transform.Find("Cell2").GetComponent<Text>().text = "class" + (i + 1);        
		} 
	} 
}