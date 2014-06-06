
#include <MCP3551.h>
#include <SPI.h>

//#define ANALOG_INPUT 1
#define ADC_INPUT 1
#define DEBUG_PROGRAM 1
#define SETDOWN_TIME_MS 10000
#define READINGTIME_SMOOTH 5000
#define BOUNDARY 5.0
#define CALCULATE_TIME 15000

#define SS 10

float fRawData;
MCP3551 MCP_ADC(SS);


float difference= 0.0;
float sig_plus = 0.0;
float sig_minus = 0.0;
float globalAverage = 0.0;
float baseFigure = 0.0;
float fMetricWeight = 0.0;

void setup(){
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  Serial.println("Setup done.");
  
  #ifdef ANALOG_INPUT
    analogReference(EXTERNAL);
    pinMode(A0, INPUT);
    pinMode(A1, INPUT);
  #endif
  
}

void getRawData(){
  bool isReady = MCP_ADC.getCode();
  if( isReady ){
    Serial.print("Raw data:");
    Serial.print(MCP_ADC.byteCode, DEC);
    Serial.println();
     Serial.print(MCP_ADC.byteCode, BIN);
    Serial.println();
    delay(2000);
  }
}

float setdownData(){
  long startTime = millis();
  float localSum = 0.0;
  unsigned int nCount = 0;
  
  
  while( (millis() - startTime) < SETDOWN_TIME_MS){
    bool isReady = MCP_ADC.getCode();
    if( isReady ){
      localSum = nCount * globalAverage;
      localSum +=  MCP_ADC.byteCode;
      nCount += 1;
      globalAverage = localSum / nCount ;
    }
  }
  
  return globalAverage;
}

float getAverageofSmooth(){
  float fres = 0.0;
  long starting = millis();
  float lSum = 0.0;
  unsigned int nCnt = 0;
  float localAvg = 0.0;
  
  
  
  while( (millis() - starting) < CALCULATE_TIME){
    fres = getSmoothReading() - baseFigure;
    if( fres < 0 ){
      fres = 0.0;
    }
    lSum = lSum * nCnt;
    lSum += fres;
    nCnt += 1;
    localAvg = lSum / nCnt;
  }
  
  nCnt = 0;
  lSum = 0.0;
  starting = 0;
  fres = 0.0;
  
  return localAvg;
}

float getSmoothReading(){
  float avg = 0.0;
  float sum = 0.0;
  float fCount = 0.0;
  
  long thisTime = millis();
  while( (millis() - thisTime) < READINGTIME_SMOOTH){
    bool isReady = MCP_ADC.getCode();
    if( isReady ){
      sum = fCount * avg;
      sum += MCP_ADC.byteCode;
      fCount += 1;
      avg = sum / fCount;
    }
  }
  
  sum = 0.0;
  fCount = 0.0;
  thisTime = 0;
  return avg;
}

void loop(){
  
  #ifdef DEBUG_PROGRAM
  
    baseFigure = setdownData();
    Serial.print("Setdown data locked:");
    Serial.print(baseFigure, DEC);
    Serial.println();
    delay(1000);
    
    Serial.println("Now looking for change");
    
    while(true){
      fMetricWeight = getAverageofSmooth();
          
      Serial.print( fMetricWeight, DEC );
      Serial.print(" Kg");
      Serial.println();
    }
    
  #endif
  
  #ifdef ADC_INPUT
  getRawData();
  #endif
  
  #ifdef ANALOG_INPUT
  Serial.print("Analog 0  :");
  
  sig_plus = analogRead(A0) *(5/1023.0);
  sig_minus = analogRead(A1) *(5/1023.0);
  Serial.print ( "Analog 0: " );
  Serial.print(sig_plus);
  Serial.print ("V.");
  Serial.println();
  
  Serial.print("Analog 1  :");
  Serial.print (sig_minus);
  Serial.print ("V.");
  Serial.println();
  
  difference = sig_plus - sig_minus;
  Serial.print("Difference: ");
  Serial.print(difference);
  Serial.println();
  delay(1000);
  
  #endif
}
