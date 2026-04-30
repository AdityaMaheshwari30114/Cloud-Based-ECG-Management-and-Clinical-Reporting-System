import React, { useState, useEffect } from "react";
import API from "../services/api";

function Devices() {
  const [devices, setDevices] = useState([]);

  useEffect(() => {
    fetchDevices();
  }, []);

  const fetchDevices = async () => {
    try {
      const res = await API.get("/device");
      setDevices(res.data);
    } catch (err) {
      console.error("Error fetching devices:", err);
    }
  };

  return (
    <div className="devices-page">
      <h1>ECG Devices</h1>
      <button className="btn-primary">Add New Device</button>
      <div className="devices-grid">
        {devices.map((device) => (
          <div key={device.device_id} className="device-card">
            <h3>{device.device_name}</h3>
            <p>Device ID: {device.device_id}</p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default Devices;
