using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class imageTracker : MonoBehaviour
{
   private ARTrackedImageManager trackedImages;
   public GameObject[] ARPrefabs;

   List<GameObject> ARObjects = new List <GameObject>();

   void Awake()
   {
        trackedImages = GetComponent<ARTrackedImageManager>();
   }

   void OnEnable()
   {
    trackedImages.trackedImagesChanged += OnTrackedImagedChanged;
   }

   void OnDisable()
   {
    trackedImages.trackedImagesChanged -= OnTrackedImagedChanged;
   }

   //create based on image tracked 
   private void OnTrackedImagedChanged(ARTrackedImagesChangedEventArgs eventArgs)
   {
        foreach (var trackedImage in eventArgs.added)
        {
            foreach(var arPrefab in ARPrefabs)
            {
                if(trackedImage.referenceImage.name == arPrefab.name)
                {
                    var newPrefab = Instantiate(arPrefab, trackedImage.transform);
                    ARObjects.Add(newPrefab);
                }
            }
        }

   

   //update tracking position
        foreach(var trackedImage in eventArgs.updated)
        {
                foreach(var gameObject in ARObjects)
                {
                    if (gameObject.name == trackedImage.name)
                    {
                        gameObject.SetActive(trackedImage.trackingState == TrackingState.Tracking);
                    }
                }
        }
   }
   

}
