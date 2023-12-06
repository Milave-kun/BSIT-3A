// Arduino Project 8: Using Passsive Piezo
// MJ "Beat it"

int buzzerPin = 8;

#define NOTE_E4 329.63
#define NOTE_G4 392.00
#define NOTE_A4 440.00
#define NOTE_B4 493.88
#define NOTE_D5 587.33

void setup() {
  pinMode(buzzerPin, OUTPUT);
}

void loop() {
  playNote(buzzerPin, NOTE_E4, 250);
  delay(250);
  playNote(buzzerPin, NOTE_D5, 250);
  delay(250);
  playNote(buzzerPin, NOTE_B4, 250);
  delay(250);
  playNote(buzzerPin, NOTE_A4, 250);
  delay(250);
  playNote(buzzerPin, NOTE_G4, 250);
  delay(250);
  playNote(buzzerPin, NOTE_E4, 250);
  delay(250);
}

void playNote(int pin, float note, int duration) {
  tone(pin, note, duration);
  delay(duration + 50);  // Add a small delay to separate the notes
}

