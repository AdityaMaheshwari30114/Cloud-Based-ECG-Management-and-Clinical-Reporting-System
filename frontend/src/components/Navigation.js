import React from "react";
import { Link } from "react-router-dom";

function Navigation() {
  return (
    <nav className="navbar">
      <div className="nav-container">
        <Link to="/" className="navbar-brand">
          ECG Management
        </Link>
        <ul className="nav-menu">
          <li className="nav-item">
            <Link to="/dashboard" className="nav-link">
              Dashboard
            </Link>
          </li>
          <li className="nav-item">
            <Link to="/patients" className="nav-link">
              Patients
            </Link>
          </li>
          <li className="nav-item">
            <Link to="/reports" className="nav-link">
              Reports
            </Link>
          </li>
          <li className="nav-item">
            <Link to="/devices" className="nav-link">
              Devices
            </Link>
          </li>
          <li className="nav-item">
            <Link to="/logout" className="nav-link logout">
              Logout
            </Link>
          </li>
        </ul>
      </div>
    </nav>
  );
}

export default Navigation;
