public class SongLyrics {
    public static void main(String[] args) {
        String title = "Dandelions";
        String singer = "Ruth B.";
        
        String stanza1 = "Verse 1:\n" +
                        "Maybe, it's the way you say my name\n" +
                        "Maybe, it's the way you play your game\n" +
                        "But it's so good, I've never known anybody like you\n" +
                        "But it's so good, I've never dreamed of nobody like you";

        String preChorus = "Pre-Chorus:\n" +
                        "And I've heard of a love that comes once in a lifetime\n" +
                        "And I'm pretty sure that you are that love of mine";

        String chorus = "Chorus:\n" +
                        "Cause I'm in a field of dandelions\n" +
                        "Wishing on every one that you'd be mine, mine\n" +
                        "And I see forever in your eyes\n" +
                        "I feel okay when I see you smile, smile";

        String postChorus = "Post-Chorus\n" +
                        "Wishing on dandelions all of the time\n" +
                        "Praying to God that one day you'll be mine\n" +
                        "Wishing on dandelions all of the time, all of the time";

        // Print the song information
        System.out.println("Title: " + title);
        System.out.println("Singer: " + singer);
        System.out.println();

        // Print the song lyrics
        System.out.println(stanza1);
        System.out.println();
        System.out.println(preChorus);
        System.out.println();
        System.out.println(chorus);
        System.out.println();
        System.out.println(postChorus);
    }
}
