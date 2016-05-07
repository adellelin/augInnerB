/*============================================================================== 
 * Copyright (c) 2012-2014 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/

using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Vuforia;

/// <summary>
/// This class implements the IVirtualButtonEventHandler interface and
/// contains the logic to swap materials for the teapot model depending on what 
/// virtual button has been pressed.
/// </summary>
public class VirtualButtonEventHandler : MonoBehaviour,
                                         IVirtualButtonEventHandler
{
    #region PUBLIC_MEMBER_VARIABLES

    /// <summary>
    /// The materials that will be set for the teapot model
    /// </summary>
    public Material[] m_TeapotMaterials;


	// The spartan king
	public Animation mSpartanKing;
    
	//the gameObject that replaces the helmet when destroyed
	public GameObject remainsPieces;

	#endregion // PUBLIC_MEMBER_VARIABLES



    #region PRIVATE_MEMBER_VARIABLES
    
    private GameObject mTeapot;
    private List<Material> mActiveMaterials;


	// the chainmail child game object
	private GameObject mChainmail;

    #endregion // PRIVATE_MEMBER_VARIABLES



    #region UNITY_MONOBEHAVIOUR_METHODS

    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }

        // Get handle to the teapot object
        mTeapot = transform.FindChild("chainmail").gameObject;
		mChainmail = transform.FindChild("chainmail_mouth").gameObject;

        // The list of active materials
        mActiveMaterials = new List<Material>();

		// Initial animation is empty
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS


    #region PUBLIC_METHODS
    
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("OnButtonPressed::" + vb.VirtualButtonName);
		Debug.Log("pressed");

		/*
        if (!IsValid())
        {
			Debug.Log ("Invald");
            return;

        }*/

        // Add the material corresponding to this virtual button
        // to the active material list:
        switch (vb.VirtualButtonName)
        {	
//			case "caroline":
//				Instantiate(remainsPieces, transform.position, transform.rotation); 
//				Destroy(mChainmail);
//				break;

//              mActiveMaterials.Add(m_TeapotMaterials[0]);
//				mSpartanKing.Play ("chainmail", AnimationPlayMode.Queue);*/
//              break;

			case "red":
				Debug.Log ("Red Clicked");
				Instantiate(remainsPieces, transform.position, transform.rotation); 
				//Destroy(mChainmail);
				mChainmail.SetActive(false);
				StartCoroutine(Chainmail());
				break;

            case "blue":
				Instantiate(remainsPieces, transform.position, transform.rotation); 
				//Destroy(mChainmail);
				
                break;

            case "yellow":
                mActiveMaterials.Add(m_TeapotMaterials[2]);
			mSpartanKing.Play ("chainmail", AnimationPlayMode.Queue);
                break;

            case "green":
                mActiveMaterials.Add(m_TeapotMaterials[3]);
				mSpartanKing.Play ("chainmail", AnimationPlayMode.Queue);
                break;
        }

        // Apply the new material:
        if (mActiveMaterials.Count > 0)
            mTeapot.GetComponent<Renderer>().material = mActiveMaterials[mActiveMaterials.Count - 1];
    }


    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        if (!IsValid())
        {
            return;
        }

        // Remove the material corresponding to this virtual button
        // from the active material list:
        switch (vb.VirtualButtonName)
        {
            case "red":
                mActiveMaterials.Remove(m_TeapotMaterials[0]);
                break;

            case "blue":
                mActiveMaterials.Remove(m_TeapotMaterials[1]);
                break;

            case "yellow":
                mActiveMaterials.Remove(m_TeapotMaterials[2]);
                break;

            case "green":
                mActiveMaterials.Remove(m_TeapotMaterials[3]);
                break;
        }

        // Apply the next active material, or apply the default material:
        if (mActiveMaterials.Count > 0)
            mTeapot.GetComponent<Renderer>().material = mActiveMaterials[mActiveMaterials.Count - 1];
        else
            mTeapot.GetComponent<Renderer>().material = m_TeapotMaterials[4];
    }


    private bool IsValid()
    {
        // Check the materials and teapot have been set:
        return  m_TeapotMaterials != null &&
                m_TeapotMaterials.Length == 5 &&
                mTeapot != null;
    }

	IEnumerator Chainmail() {
		yield return new WaitForSeconds(5);
		mChainmail.SetActive(true);
	}
	#endregion // PUBLIC_METHODS
}
