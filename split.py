import os 
import argparse
import subprocess 

def split_video(input_file, output_prefix, chunk_duration):
    # Construct the FFmpeg command
    command = [
        'D:/ffmpeg/bin/ffmpeg.exe',
        '-i', input_file,           # Input file
        '-c', 'copy',               # Copy codec (no re-encoding)
        '-map', '0',                # Map all streams
        '-segment_time', str(chunk_duration),  # Duration of each segment
        '-f', 'segment',            # Split format
        '-reset_timestamps', '1',   # Reset timestamps at each segment
        f'{output_prefix}_%03d.mp4' # Output filename pattern
    ]

    # Run the command using subprocess
    try:
        subprocess.run(command, check=True)
        print("Video split successfully!")
    except FileNotFoundError:
        print("FFmpeg executable not found. Ensure FFmpeg is installed and the PATH is set correctly.")
    except subprocess.CalledProcessError as e:
        print(f"An error occurred: {e}")


def main():
    parser = argparse.ArgumentParser(description="Split an MP4 video into chunks.")
    parser.add_argument('input_file', help='Path to the input MP4 file')
    parser.add_argument('output_prefix', help='Prefix for the output chunk files')
    parser.add_argument('chunk_duration', type=int, help='Duration of each chunk in seconds')
    
    args = parser.parse_args()
    
    split_video(args.input_file, args.output_prefix, args.chunk_duration)

if __name__ == "__main__":
    main()