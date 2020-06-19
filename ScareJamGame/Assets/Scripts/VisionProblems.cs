using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CinematicEffects;

public class VisionProblems : MonoBehaviour {
    Bloom scriptBloom;
    LensAberrations scriptLensAberrations;
    TonemappingColorGrading scriptTonemappingColorGrading;

    float maxBloomIntensity = 80.0f, actualBloomIntensity = 0.0f; //BLOOM
    float maxDistortionAmount = 60.0f, actualDistortionAmount = 0.0f, 
        maxVignetteIntensity = 3.0f, actualVignetteIntensity = 0.0f, 
        maxChromaticAberration = 50.0f, actualChromaticAberration = 0.0f; //LENS ABERRATION
    float actualRedColor = 0.0f;

    int randomThing = 0;

    bool stateOfDistortion = false;

    // Use this for initialization
    void Start () {
        randomThing = (int)Random.Range(0, 3);
        scriptBloom = GetComponent<Bloom>() as Bloom;
        scriptLensAberrations = GetComponent<LensAberrations>() as LensAberrations;
        scriptTonemappingColorGrading = GetComponent<TonemappingColorGrading>() as TonemappingColorGrading;

        Debug.Log("Type of desease " + randomThing);
    }

    // Update is called once per frame
    void Update()
    {
        switch (randomThing)
        {
            case 0:
                //USE RANDOM TO CHOOSE WHICH USE PROPERLY
                UseBloomProperly();
                break;
            case 1:
                UseDistortionProperly();
                break;
            case 2:
                UseVignetteandChromaticProperly();
                break;
            case 3:
                UseChromaticAborration();
                break;
        }
    }

    private void UseBloomProperly()
    {
        if (actualBloomIntensity < maxBloomIntensity)
        {
            actualBloomIntensity += 0.1f * Time.deltaTime;
        }

        scriptBloom.settings.dirtIntensity += 0.01f * Time.deltaTime;

        scriptBloom.settings.intensity = actualBloomIntensity;

        UseVignetteandChromaticProperly();
    }

    private void UseDistortionProperly()
    {
        if (!stateOfDistortion)
        {
            if (actualDistortionAmount > maxDistortionAmount)
            {
                stateOfDistortion = true;
            }

            actualDistortionAmount += 6.5f * Time.deltaTime;
        }
        else
        {
            if (actualDistortionAmount < -maxDistortionAmount)
            {
                stateOfDistortion = false;
            }
            actualDistortionAmount -= 6.5f * Time.deltaTime;
        }

        scriptLensAberrations.distortion.amount = actualDistortionAmount;
    }

    private void UseDistortionProperly(float number)
    {
        if (!stateOfDistortion)
        {
            if (actualDistortionAmount > maxDistortionAmount)
            {
                stateOfDistortion = true;
            }

            actualDistortionAmount += number * Time.deltaTime;
        }
        else
        {
            if (actualDistortionAmount < -maxDistortionAmount)
            {
                stateOfDistortion = false;
            }
            actualDistortionAmount -= number * Time.deltaTime;
        }

        scriptLensAberrations.distortion.amount = actualDistortionAmount;
    }

    private void UseVignetteandChromaticProperly()
    {
        if (actualVignetteIntensity < maxVignetteIntensity)
        {
            actualVignetteIntensity += 0.02f * Time.deltaTime;
        }

        scriptLensAberrations.vignette.intensity = actualVignetteIntensity;
    }

    private void UseVignetteandChromaticProperly(float speedVignette)
    {
        if (actualVignetteIntensity < maxVignetteIntensity)
        {
            actualVignetteIntensity += speedVignette * Time.deltaTime;
        }

        scriptLensAberrations.vignette.intensity = actualVignetteIntensity;
    }

    private void UseChromaticAborration() { 
        if (actualChromaticAberration < maxChromaticAberration)
        {
            actualChromaticAberration += 0.5f * Time.deltaTime;
        }

        scriptLensAberrations.chromaticAberration.amount = actualChromaticAberration;
        UseVignetteandChromaticProperly(0.005f);
    }
}
