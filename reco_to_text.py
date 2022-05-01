import speech_recognition as sr

r = sr.Recognizer()
with sr.Microphone() as s:
    print('speak anythings...')
    audio = r.listen(s)
    try : 
        text = r.recognize_google(audio)
        print('you said {}'.format(text))
    except : 
        print('something is happened!!!')