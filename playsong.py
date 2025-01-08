import speech_recognition as sr
import os
import platform

# Function to play the song using VLC
def play_song(song_title):
    song_path = None
    
    # Set the song path based on the title
    song_titles = {
        "what is love": "https://www.youtube.com/watch?v=D2h4PhgobI8&list=RDD2h4PhgobI8&start_radio=1",  # Windows path example
        "fuck that": "https://www.youtube.com/watch?v=6OnGU66rPkI",
        "domination": "https://www.youtube.com/watch?v=aDACorIaxNw&list=RDaDACorIaxNw&start_radio=1",
        "stillborn": "https://www.youtube.com/watch?v=9ZGt4JVX860",
        "casey treat": "https://www.youtube.com/watch?v=cKzMCuQHsSE",
        "sting": "https://www.youtube.com/watch?v=C3lWwBslWqg",
        "slipknot": "https://www.youtube.com/watch?v=ZPUZwriSX4M",
    }

    # Try to find the song path for the given title
    song_path = song_titles.get(song_title.lower())
    
    if not song_path:
        print("Song not found in the list.")
        return

    # Play the song using VLC
    if platform.system() == "Windows":
        os.system(f'start {song_path}')
    elif platform.system() == "Darwin" or platform.system() == "Linux":
        os.system(f'xdg-open {song_path}')
    else:
        print("Unsupported OS. Cannot play the song.")
        
    print(f"Playing '{song_title}'...")

# Function to listen for a song title
def listen_for_song():
    recognizer = sr.Recognizer()

    # Start the microphone stream
    with sr.Microphone() as source:
        print("Listening for song title...")
        recognizer.adjust_for_ambient_noise(source)

        while True:
            try:
                # Listen for audio input
                audio = recognizer.listen(source)
                print("Recognizing...")
                # Use Google's speech recognition to convert speech to text
                text = recognizer.recognize_google(audio).lower()

                print(f"Detected: {text}")
                
                # Check if the detected speech is a known song title
                if "what is love" in text:
                    print("what is love detected!")
                    play_song("what is love")
                    break
                elif "fuck that" in text:
                    print("fuck that detected!")
                    play_song("fuck that")
                    break
                elif "domination" in text:
                    print("domination detected!")
                    play_song("domination")
                    break
                elif "stillborn" in text:
                    print("still born detected!")
                    play_song("stillborn")
                    break
                elif "casey treat" in text:
                    print("casey tream detected!")
                    play_song("casey treat")
                    break
                elif "slipknot" in text:
                    print("slipknot!")
                    play_song("slipknot")
                    break
                elif "sting" in text:
                    print("sting!")
                    play_song("sting")
                    break
                else:
                    print("Unrecognized song title. Try again.")
                
            except sr.UnknownValueError:
                # If speech is unintelligible, continue listening
                continue
            except sr.RequestError:
                # If there's an issue with the API, stop
                print("Could not request results from Google Speech Recognition service.")
                break

# Main program
if __name__ == "__main__":
    listen_for_song()
