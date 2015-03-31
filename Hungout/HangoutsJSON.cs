using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hungout
{
    public class HangoutsJSON
    {
        public string json { get; set; }
        private RootObject jsonObject { get; set; }

        public RootObject parse(){
            RootObject obj = JsonConvert.DeserializeObject<RootObject>(json);
            Console.WriteLine("JSON Converted to Object!");
            return obj;
        }
    }

    public class ConversationId
    {
        public string id { get; set; }
    }

    public class ResponseHeader
    {
        public string status { get; set; }
        public string debug_url { get; set; }
        public string request_trace_id { get; set; }
        public string current_server_time { get; set; }
    }

    public class ConversationId2
    {
        public string id { get; set; }
    }

    public class Id
    {
        public string id { get; set; }
    }

    public class ParticipantId
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class SelfReadState
    {
        public ParticipantId participant_id { get; set; }
        public string latest_read_timestamp { get; set; }
    }

    public class InviterId
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class DeliveryMedium
    {
        public string medium_type { get; set; }
    }

    public class DeliveryMediumOption
    {
        public DeliveryMedium delivery_medium { get; set; }
        public bool current_default { get; set; }
    }

    public class SelfConversationState
    {
        public SelfReadState self_read_state { get; set; }
        public string status { get; set; }
        public string notification_level { get; set; }
        public List<string> view { get; set; }
        public InviterId inviter_id { get; set; }
        public string invite_timestamp { get; set; }
        public string sort_timestamp { get; set; }
        public string active_timestamp { get; set; }
        public List<DeliveryMediumOption> delivery_medium_option { get; set; }
    }

    public class ParticipantId2
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class ReadState
    {
        public ParticipantId2 participant_id { get; set; }
        public string latest_read_timestamp { get; set; }
    }

    public class CurrentParticipant
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class Id2
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class ParticipantData
    {
        public Id2 id { get; set; }
        public string fallback_name { get; set; }
        public string invitation_status { get; set; }
        public string participant_type { get; set; }
    }

    public class Conversation
    {
        public Id id { get; set; }
        public string type { get; set; }
        public SelfConversationState self_conversation_state { get; set; }
        public List<ReadState> read_state { get; set; }
        public bool has_active_hangout { get; set; }
        public string otr_status { get; set; }
        public string otr_toggle { get; set; }
        public List<CurrentParticipant> current_participant { get; set; }
        public List<ParticipantData> participant_data { get; set; }
        public bool fork_on_external_invite { get; set; }
        public List<string> network_type { get; set; }
        public string force_history_state { get; set; }

        override public string ToString()
        {
            string name = "";
            foreach(ParticipantData p in participant_data) {
                name = name + " " + p.fallback_name + " ";
            }
            return name;
        }

    }

    public class EventContinuationToken
    {
        public string storage_continuation_token { get; set; }
        public string event_timestamp { get; set; }
    }

    public class ConversationId3
    {
        public string id { get; set; }
    }

    public class SenderId
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class UserId
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class EasterEggSuggestionInfo
    {
        public int variation_index { get; set; }
        public int animation_duration_msec { get; set; }
        public List<string> animated_asset_url_without_suffix { get; set; }
        public string horizontal_alignment { get; set; }
    }

    public class Suggestion
    {
        public string suggestion_id { get; set; }
        public string expiration_time_usec { get; set; }
        public string type { get; set; }
        public EasterEggSuggestionInfo easter_egg_suggestion_info { get; set; }
        public string matched_message_substring { get; set; }
    }

    public class Suggestions
    {
        public List<Suggestion> suggestion { get; set; }
    }

    public class SelfEventState
    {
        public UserId user_id { get; set; }
        public string notification_level { get; set; }
        public string client_generated_id { get; set; }
        public Suggestions suggestions { get; set; }
    }

    public class Formatting
    {
        public bool bold { get; set; }
        public bool italics { get; set; }
        public bool strikethrough { get; set; }
        public bool underline { get; set; }
    }

    public class LinkData
    {
        public string link_target { get; set; }
    }

    public class Segment
    {
        public string type { get; set; }
        public string text { get; set; }
        public Formatting formatting { get; set; }
        public LinkData link_data { get; set; }
    }

    public class Thumbnail
    {
        public string url { get; set; }
        public string image_url { get; set; }
        public int width_px { get; set; }
        public int height_px { get; set; }
    }

    public class EmbedsPlusPhotoPlusPhoto
    {
        public Thumbnail thumbnail { get; set; }
        public string owner_obfuscated_id { get; set; }
        public string album_id { get; set; }
        public string photo_id { get; set; }
        public string url { get; set; }
        public string original_content_url { get; set; }
        public string media_type { get; set; }
        public List<string> stream_id { get; set; }
    }

    public class EmbedItem
    {
        public List<string> type { get; set; }
        public EmbedsPlusPhotoPlusPhoto embeds { get; set; }
    }

    public class Attachment
    {
        public EmbedItem embed_item { get; set; }
    }

    public class MessageContent
    {
        public List<Segment> segment { get; set; }
        public List<Attachment> attachment { get; set; }
    }

    public class ChatMessage
    {
        public MessageContent message_content { get; set; }
    }

    public class DeliveryMedium2
    {
        public string medium_type { get; set; }
    }

    public class Event
    {
        public ConversationId3 conversation_id { get; set; }
        public SenderId sender_id { get; set; }
        public string timestamp { get; set; }
        public SelfEventState self_event_state { get; set; }
        public ChatMessage chat_message { get; set; }
        public string event_id { get; set; }
        public bool advances_sort_timestamp { get; set; }
        public string event_otr { get; set; }
        public DeliveryMedium2 delivery_medium { get; set; }
        public string event_type { get; set; }
        public string event_version { get; set; }
        
        override public string ToString()
        {
            if (chat_message.message_content.segment == null) return "";
            return chat_message.message_content.segment.ElementAt(0).text;
        }
    }

    public class ConversationState2
    {
        public ConversationId2 conversation_id { get; set; }
        public Conversation conversation { get; set; }
        public EventContinuationToken event_continuation_token { get; set; }
        public List<Event> @event { get; set; }
    }

    public class ConversationState
    {
        public ConversationId conversation_id { get; set; }
        public ResponseHeader response_header { get; set; }
        public ConversationState2 conversation_state { get; set; }

        public override string ToString()
        {
            return conversation_state.conversation.ToString();
        }
    }

    public class RootObject
    {
        public List<ConversationState> conversation_state { get; set; }
    }

}
