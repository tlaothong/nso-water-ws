# NSO Water WS
## Web Services for Water Database:
### a project of NSO.

This is the repo for a team working on Water Database project.

## Data from Thai Water
The web service which contains most of the data we need is Thai Water.
It's webservice is over here

[WebService API for Data Services](http://web.thaiwater.net/thaiwater30/api-docs/dataservice#/thaiwater30)

### First access

| ชื่อข้อมูล                         | หน่วยงาน                   | จังหวัด                                                                                             | ประเภทการรับข้อมูล   | ช่วงเวลาของข้อมูล | ช่องทางการรับข้อมูล                                                                            |
|--------------------------------|---------------------------|---------------------------------------------------------------------------------------------------|-------------------|----------------|-----|
| ระดับน้ำ จากระบบโทรมาตรเขื่อนภูมิพล  | การไฟฟ้าฝ่ายผลิตแห่งประเทศไทย |                                                                                                   | เว็บเซอร์วิสข้อมูลล่าสุด |                |  77  |
| ฝน จากระบบโทรมาตรเขื่อนภูมิพล      | การไฟฟ้าฝ่ายผลิตแห่งประเทศไทย |                                                                                                   | เว็บเซอร์วิสข้อมูลล่าสุด |                | 76  |
| ข้อมูลอ่างเก็บน้ำขนาดใหญ่ (รายชัวโมง) | การไฟฟ้าฝ่ายผลิตแห่งประเทศไทย | อุบลราชธานี , ชัยภูมิ , ขอนแก่น , สกลนคร , เชียงใหม่ , อุตรดิตถ์ , ตาก , กาญจนบุรี , เพชรบุรี , สุราษฎร์ธานี , ยะลา | เว็บเซอร์วิสข้อมูลล่าสุด | |  75  |
| ข้อมูลอ่างเก็บน้ำขนาดใหญ่ (รายวัน)    | การไฟฟ้าฝ่ายผลิตแห่งประเทศไทย | อุบลราชธานี , ชัยภูมิ , ขอนแก่น , สกลนคร , เชียงใหม่ , อุตรดิตถ์ , ตาก , กาญจนบุรี , เพชรบุรี , สุราษฎร์ธานี , ยะลา | เว็บเซอร์วิสข้อมูลล่าสุด | |74  |
| พื้นฐานเขื่อน                      | การไฟฟ้าฝ่ายผลิตแห่งประเทศไทย |                                                                                                   | เว็บเซอร์วิสข้อมูลล่าสุด |                |  84  |

### TODO1
1. Play with the web api to understand how to use and its parameters.
    * Report parameter format every group.
2. Export sample data in Excel or CSV 2-3 tables for each webservice.

### TODO2
3. List all api in the system to simplest form (CSV)
