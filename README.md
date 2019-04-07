# Fuzzy-Inference-System-Mamdani

![alt_text](http://teemstudios.net/wp-content/uploads/2019/04/Cover-1.jpg)

Create a simulation of the automatic braking system on the vehicle using a Fuzzy Inference System (FIS) Mamdani.

## HOW IT WORKS
There are 3 Membership Function for input and 1 for output.

| I/O | Variable Name | Himpunan Universal |
| --- | --- | --- |
| Speed (km/h) | Speed | 0,120 |
| Disatance (m) | Distance | 0,10 | 
| Angle (degree) | Angle | -90,90 |
| Brake Level | Brake Level | 0,10 |

## Membership Function for Input :
### Angle
![alt_text](http://teemstudios.net/wp-content/uploads/2019/04/MF-Angle.png)

### Distance
![alt_text](http://teemstudios.net/wp-content/uploads/2019/04/MF-Distance.png)

### Speed
![alt_text](http://teemstudios.net/wp-content/uploads/2019/04/MF-Speed.png)


## Membership Funciton for Output :
### Brake Level
![alt_text](http://teemstudios.net/wp-content/uploads/2019/04/MF-Brake.png)

## RULES
1. If (Speed is Slow) and (Distance is Near) and (Angle is Down) then (BrakeLevel is Strong) 
2. If (Speed is Slow) and (Distance is Near) and (Angle is Up) then (BrakeLevel is Weak)  
3. If (Speed is Slow) and (Distance is Near) and (Angle is Flat) then (BrakeLevel is Medium)  
4. If (Speed is Slow) and (Distance is Jauh) and (Angle is Flat) then (BrakeLevel is Weak)  
5. If (Speed is Slow) and (Distance is Jauh) and (Angle is Up) then (BrakeLevel is Weak)  
6. If (Speed is Slow) and (Distance is Jauh) and (Angle is Down) then (BrakeLevel is Medium)  
7. If (Speed is Slow) and (Distance is TooFar) and (Angle is Flat) then (BrakeLevel is Weak)  
8. If (Speed is Slow) and (Distance is TooFar) and (Angle is Up) then (BrakeLevel is Weak)  
9. If (Speed is Slow) and (Distance is TooFar) and (Angle is Down) then (BrakeLevel is Medium)  
10. (Speed is Medium) and (Distance is Near) and (Angle is Flat) then (BrakeLevel is Strong)  
11. (Speed is Medium) and (Distance is Near) and (Angle is Up) then (BrakeLevel is Medium)  
12. (Speed is Medium) and (Distance is Near) and (Angle is Down) then (BrakeLevel is Strong)  
13. (Speed is Medium) and (Distance is Jauh) and (Angle is Flat) then (BrakeLevel is Medium)  
14. (Speed is Medium) and (Distance is Jauh) and (Angle is Up) then (BrakeLevel is Weak)  
15. (Speed is Medium) and (Distance is Jauh) and (Angle is Down) then (BrakeLevel is Strong)  
16. (Speed is Medium) and (Distance is TooFar) and (Angle is Flat) then (BrakeLevel is Weak)  
17. (Speed is Medium) and (Distance is TooFar) and (Angle is Up) then (BrakeLevel is Weak)  
18. (Speed is Medium) and (Distance is TooFar) and (Angle is Down) then (BrakeLevel is Medium)  
19. (Speed is Cepat) and (Distance is Near) and (Angle is Flat) then (BrakeLevel is Strong)  
20. (Speed is Cepat) and (Distance is Near) and (Angle is Up) then (BrakeLevel is Medium)  
21. (Speed is Cepat) and (Distance is Near) and (Angle is Down) then (BrakeLevel is Strong)  
22. (Speed is Cepat) and (Distance is Jauh) and (Angle is Flat) then (BrakeLevel is Strong)  
23. (Speed is Cepat) and (Distance is Jauh) and (Angle is Up) then (BrakeLevel is Medium)  
24. (Speed is Cepat) and (Distance is Jauh) and (Angle is Down) then (BrakeLevel is Strong)  
25. (Speed is Cepat) and (Distance is TooFar) and (Angle is Flat) then (BrakeLevel is Medium)  
26. (Speed is Cepat) and (Distance is TooFar) and (Angle is Up) then (BrakeLevel is Weak)  
27. (Speed is Cepat) and (Distance is TooFar) and (Angle is Down) then (BrakeLevel is Strong)  




## MORE INFORMATION
Visit http://teemstudios.net or chat on whatsapp (62)857 9500 2903
