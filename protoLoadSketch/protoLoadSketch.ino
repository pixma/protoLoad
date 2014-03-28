

//////////////////////////////////////////////////////////////
//
//  define macros here
//
#ifndef WITH_LCD
#define WITH_LCD 1
#endif
#ifndef WITH_SERIAL
#define WITH_SERIAL 1
#endif
//////////////////////////////////////////////////////////////
//
//  define macros end here
//

#if defined( WITH_LCD )
#include <LiquidCrystal.h>
#endif

#define AVG_COUNT 10

//LiquidCrystal lcd( RS, EN, D4, D5, D6, D7); of lcd to MCU/ Arduino
LiquidCrystal lcd( 1, 2, 3, 4, 5, 6);

//getWeight() function
int totalValue = 0;
int tearValue = 0;
int getWeight()
{
  
  for(unsigned char i = 0; i<AVG_COUNT; i++)
  {
    totalValue += analogRead(A0);
    delay(10);        // delay in between reads for stability
  }
   
  totalValue = (totalValue / AVG_COUNT) - tearValue;  
     
  return -totalValue;// need to revist the code at this point.
}
 
//resetTear() function
void resetTear()
{
  int total = 0;
  for(unsigned char i = 0; i<AVG_COUNT; i++)
  {
    total += analogRead(A0);
    delay(10);        // delay in between reads for stability
  }
  total /= AVG_COUNT;
  tearValue = total;
}

void setup(){
  
  #if defined(WITH_SERIAL)
    Serial.begin(9600);
    Serial.println("ProtoLoad Started...");
  #endif
  
  #if defined( WITH_LCD)
    lcd.begin(16, 2 );
    lcd.clear();
    lcd.setCursor(5, 0);
    lcd.print("ProtoLoad");
    delay( 5000 );
   #endif
 
   resetTear();  
}

void loop(){
  
  #if defined(WITH_SERIAL)  
  Serial.println("Weight: " + getWeight());
  //code need to be revisted here, for unit and quantity correctness check.
  #endif
  
  #if defined(WITH_LCD)
  lcd.println("Weight: ");
  lcd.print(getWeight());
  //code need to be revisted here, for unit and quantity correctness check.
  delay( 1000 );
  #endif
}

