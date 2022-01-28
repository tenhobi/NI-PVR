using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScoreController ScoreController;
    [SerializeField] private GameObject gunsHolder;
    [SerializeField] private AudioSource sound;

    [SerializeField] private GameObject[] targets;

    private List<Rigidbody> _rigidbodies = new List<Rigidbody>();
    private List<Vector3> _positions = new List<Vector3>();
    private List<Quaternion> _rotations = new List<Quaternion>();

    void Awake()
    {
        var allRigidbodies = gunsHolder.GetComponentsInChildren<Rigidbody>();
        foreach(var r in allRigidbodies)
        {
            _rigidbodies.Add(r);
            _positions.Add(r.transform.position);
            _rotations.Add(r.transform.localRotation);
        }

        GenerateAnotherTarget();
        GenerateAnotherTarget();
        GenerateAnotherTarget();
        GenerateAnotherTarget();
        GenerateAnotherTarget();
        GenerateAnotherTarget();
        GenerateAnotherTarget();
    }

    public void Score(int score)
    {
        ScoreController.ScoredAction(score);
        if (sound != null) sound.Play();
        GenerateAnotherTarget();
    }

    public void ResetWeapons()
    {
        for (int i = 0; i < _rigidbodies.Count; ++i)
        {
            _rigidbodies[i].useGravity = false;
            _rigidbodies[i].transform.position = _positions[i];
            _rigidbodies[i].transform.localRotation = _rotations[i];            
        }
    }

    public void ResetGame()
    {
        ScoreController.ResetAction();
    }

    private void GenerateAnotherTarget()
    {
        var random = new System.Random();
        int r = random.Next(targets.Length);
        Instantiate(targets[r]);
    }
}
