/*
This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software Foundation,
Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.

The Original Code is Copyright (C) 2020 Voxell Technologies.
All rights reserved.
*/

using System.Runtime.CompilerServices;

namespace SmartAssistant.UX
{
  // Conditions explained: https://openweathermap.org/weather-conditions
  [System.Serializable]
  public struct WeatherStatus 
  {
    public int weatherId;
    public string main;
    public string description;
    public float temperature;
    public float pressure;
    public float windSpeed;
    public string weatherIcon;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float Celsius() => temperature - 273.15f;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float Fahrenheit() => Celsius() *1.8f +32f;
  }

  [System.Serializable]
  public struct CityList
  {
    // structure to decode from json file
    public int id;
    public string name;
    public string state;
    public string country;
  }
}