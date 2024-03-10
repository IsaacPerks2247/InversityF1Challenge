from urllib.request import urlopen
import json

#first driver number: 44
firstCarDataQuery = "https://api.openf1.org/v1/car_data?driver_number=44&session_key=latest&brake>=0&rpm>=0&speed>=0&throttle>=0"
firstIntervalsQuery = "https://api.openf1.org/v1/intervals?driver_number=44&session_key=latest&gap_to_leader>0&interval<20"
firstLapsQuery = "https://api.openf1.org/v1/laps?driver_number=44&session_key=latest&duration_sector_1>=0&duration_sector_2>=0&duration_sector_3>=0&lap_duration>=0&lap_number>=1&st_speed>=1"
firstPitQuery = "https://api.openf1.org/v1/pit?driver_number=44&session_key=latest&lap_number>=1"
firstStintsQuery = "https://api.openf1.org/v1/stints?driver_number=44&session_key=latest&tyre_age_at_start>=0"
firstWeatherQuery = "https://api.openf1.org/v1/weather?driver_number=44&session_key=latest&rainfall>=0"

#second driver number: 63
secondCarDataQuery = "https://api.openf1.org/v1/car_data?driver_number=63&session_key=latest&brake>=0&rpm>=0&speed>=0&throttle>=0"
secondIntervalsQuery = "https://api.openf1.org/v1/intervals?driver_number=63&session_key=latest&gap_to_leader>0&interval<20"
secondLapsQuery = "https://api.openf1.org/v1/laps?driver_number=63&session_key=latest&duration_sector_1>=0&duration_sector_2>=0&duration_sector_3>=0&lap_duration>=0&lap_number>=1&st_speed>=1"
secondPitQuery = "https://api.openf1.org/v1/pit?driver_number=63&session_key=latest&lap_number>=1"
secondStintsQuery = "https://api.openf1.org/v1/stints?driver_number=63&session_key=latest&tyre_age_at_start>=0"
secondWeatherQuery = "https://api.openf1.org/v1/weather?driver_number=63&session_key=latest&rainfall>=0"

#in an array for ease
querys = [firstCarDataQuery, firstIntervalsQuery, firstLapsQuery, firstPitQuery, firstStintsQuery, firstWeatherQuery, secondCarDataQuery, secondIntervalsQuery, secondLapsQuery, secondPitQuery, secondStintsQuery, secondWeatherQuery]
#corrosponding file paths
queryPaths = ["firstCarData.txt",
               "firstIntervals.txt",
               "firstLaps.txt",
               "firstPit.txt",
               "firstStints.txt",
               "firstWeather.txt",
               "secondCarData.txt",
               "secondIntervals.txt",
               "secondLaps.txt",
               "secondPit.txt",
               "secondStints.txt",
               "secondWeather.txt"]

#while True:
#    try:
#        for i in range(12):
#            UrlResponse = urlopen(querys[i])#open each URL
#            data = json.loads(UrlResponse.read().decode('utf-8'))#get data
#            with open(queryPaths[i], "w") as file:#open corresponding database
#                file.truncate(0)#clears file
#                file.write(str(data))#write data
#            print(i)
#        print("done")
#    except KeyboardInterrupt:
#        print("Program terminated by user.")
#        break

on = True
while on:#program has to be shut using "ctrl + c" or any other method, needs to run in background
    for i in range(12):
        UrlResponse = urlopen(querys[i])#open each url
        data = json.loads(UrlResponse.read().decode('utf-8'))#get data
        file = open(queryPaths[i], "w")#open corrosponding database
        file.truncate(0)#clears file
        if i == 0 or i == 6 or i == 2 or i == 8:
            file.write(str(data[0]))#write data
        else:
            file.write(str(data))
        file.close()#close file
        print(i)
    print("done")
