import base64

encoded_string_1 = "/stKUES1ixbMhOlJlB+SWA=="
decoded_bytes_1 = base64.b64decode(encoded_string_1)
decoded_string_1 = decoded_bytes_1.decode('utf-16')
print("Decoded string 1: " + decoded_string_1)

encoded_string_2 = "pBIpqi6Va4CPWYwUZH3erg=="
decoded_bytes_2 = base64.b64decode(encoded_string_2)
decoded_string_2 = decoded_bytes_2.decode('utf-16')
print("Decoded string 2: " + decoded_string_2)

encoded_string_3 = "E9e5ZS9/1A50ORqMLIn1+g=="
decoded_bytes_3 = base64.b64decode(encoded_string_3)
decoded_string_3 = decoded_bytes_3.decode('utf-16')
print("Decoded string 3: " + decoded_string_3)