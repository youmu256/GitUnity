using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class CanYing : MonoBehaviour {

    public float interval = 0.1f;
    public float lifeCycle = 2.0f;

    float lastCombinedTime = 0.0f;

    MeshFilter[] meshFilters = null;

    MeshRenderer[] meshRenderers = null;

    SkinnedMeshRenderer[] skinedMeshRenderers = null;

    List<GameObject> objs = new List<GameObject>();

    private Animation animation;


	// Use this for initialization
	void Start () {
	    animation = this.GetComponent<Animation>();
        meshFilters = gameObject.GetComponentsInChildren<MeshFilter>();
        skinedMeshRenderers = gameObject.GetComponentsInChildren<SkinnedMeshRenderer>();

        Messager.AddListener("AnimationPlayClick",OnClickPlayAnimation);

	}

    void OnDisable()
    {
        foreach (GameObject go in objs)
        {
            DestroyImmediate(go);
        }
        objs.Clear();
        objs = null;
    }


    private float lastTime = 0f;
    private float lastTimer = 0f;
    public float CanYingTotalLastTime = 1f;

    void OnClickPlayAnimation() {
        lastTimer = 0;
        lastTime = CanYingTotalLastTime;
        animation.wrapMode = WrapMode.Once;
    }

    bool CheckIsInAnimation() {
        lastTimer += Time.deltaTime;
        if (lastTimer < lastTime) {
            return true;
        } else {
            //lastTimer = 0;
        }
        return false;
        //return !animation.IsPlaying("Idle");
    }




	// Update is called once per frame
	void Update () {
	    if (!CheckIsInAnimation()) return;

        if (Time.time - lastCombinedTime > interval)
        {
            lastCombinedTime = Time.time;

            for (int i = 0; skinedMeshRenderers != null && i < skinedMeshRenderers.Length; ++i)
            {
                Mesh mesh = new Mesh();

                skinedMeshRenderers[i].BakeMesh(mesh);

                GameObject go = new GameObject();

                go.hideFlags = HideFlags.HideAndDontSave;
                MeshFilter meshFilter = go.AddComponent<MeshFilter>();
                meshFilter.mesh = mesh;

                MeshRenderer meshRenderer = go.AddComponent<MeshRenderer>();
                meshRenderer.material = skinedMeshRenderers[i].material;

                InitFadeInObj(go, skinedMeshRenderers[i].transform.position,
                    skinedMeshRenderers[i].transform.rotation, lifeCycle);
            }
            for (int i = 0; meshFilters != null && i < meshFilters.Length; ++i)
            {
                GameObject go = Instantiate(meshFilters[i].gameObject) as GameObject;
                InitFadeInObj(go, meshFilters[i].transform.position, meshFilters[i].transform.rotation, lifeCycle);
            }
        }
	}

    private void InitFadeInObj(GameObject go, Vector3 position, Quaternion rotation, float lifeCycle)
    {
        go.hideFlags = HideFlags.HideAndDontSave;
        go.transform.position = position;
        go.transform.rotation = rotation;

        FadInOut fi = go.AddComponent<FadInOut>();
        fi.lifeCycle = lifeCycle;
        objs.Add(go);
    }
}
