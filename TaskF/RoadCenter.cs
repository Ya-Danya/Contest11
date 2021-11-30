using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

public class RoadCenter : ITrackingCenter
{
    private List<Camera> cameras = new List<Camera>();
    public void AddCamera(int id, int maxSpeed)
    {
        cameras.Add(new Camera(id,maxSpeed));
    }

    public void CheckCarSpeed(int forCameraId, int carNumber, int carSpeed)
    {
        foreach (var item in cameras)
        {
            if (item.id == forCameraId)
            {
                if (item.maxSpeed > carSpeed)
                {
                    item.AddPenalty(carNumber,carSpeed);
                }
            }
        }
    }

    public void GetData(string inFilePath)
    {
        FileStream fileStream = new FileStream(inFilePath, FileMode.OpenOrCreate, FileAccess.Write);
        DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(RoadCenter));
        dataContractJsonSerializer.WriteObject(fileStream, this);
    }
}